using Microsoft.AspNetCore.Mvc.Rendering;
using EDI.ApplicationCore.Entities;
using EDI.ApplicationCore.Interfaces;
using EDI.ApplicationCore.Specifications;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using EDI.Web.Models;
using EDI.Web.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using EDI.Infrastructure.Interfaces;
using Serilog;
using EDI.Web.Lib;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.Authorization;
using EDI.Web.Extensions;

namespace EDI.Web.Services
{
    public class FormService  : IFormService
    {
        private readonly ILogger<FormService> _logger;
        private readonly IAsyncRepository<FormConfigurations> _formRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private EDIAppSettings POAppSettings { get; set; }
        private readonly IAsyncIdentityRepository _accountRepository;
        private IHostEnvironment _hostingEnvironment;

        private string _username { get; set; }

        private const int TOKEN_REPLACEMENT_IN_SECONDS = 10 * 60;
        private static string AccessToken { get; set; }
        private static int expiresIn;

        public FormService(
            ILoggerFactory loggerFactory,
            IAsyncRepository<FormConfigurations> formRepository,
            IAsyncIdentityRepository accountRepository,
            IHostEnvironment hostingEnvironment,
            IHttpContextAccessor httpContextAccessor,
            AuthenticationStateProvider authenticationStateProvider,
            IOptions<EDIAppSettings> settings)
        {
            _logger = loggerFactory.CreateLogger<FormService>();
            _httpContextAccessor = httpContextAccessor;
            _formRepository = formRepository;
            _accountRepository = accountRepository;
            _hostingEnvironment = hostingEnvironment;
            _authenticationStateProvider = authenticationStateProvider;
            POAppSettings = settings.Value;
        }

        private async Task LogUsername()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user != null)
                _username = user.Identity.Name;
            else
                _username = string.Empty;
        }

        public async Task DeleteFormAsync(int Id)
        {
            await LogUsername();
            Log.Information("DeleteFormAsync started by:" + _username);

            try
            {
                var form = await _formRepository.GetByIdAsync(Id);

                await _formRepository.DeleteAsync(form);
            }
            catch (Exception ex)
            {
                Log.Error("DeleteFormAsync failed:" + ex.Message);
            }
        }

        public async Task UpdateFormAsync(FormItemViewModel form)
        {
            await LogUsername();
            Log.Information("UpdateFormAsync started by:" + _username);

            try
            {
                var _form = await _formRepository.GetByIdAsync(form.Id);

                _form.FormName = form.FormName;
                _form.FieldName = form.FieldName;
                _form.Order = form.Order;
                _form.IsRequired = form.IsRequired;
                _form.IsEnabled = form.IsEnabled;
                _form.IsVisible = form.IsVisible;
                _form.ModifiedDate = DateTime.Now;
                _form.ModifiedBy = _username;

                await _formRepository.UpdateAsync(_form);
            }
            catch (Exception ex)
            {
                Log.Error("UpdateFormAsync failed:" + ex.Message);
            }
        }

        public async Task CreateFormAsync(FormItemViewModel form)
        {
            await LogUsername();
            Log.Information("CreateFormAsync started by:" + _username);

            try
            {
                var _form = new FormConfigurations();

                _form.FormName = form.FormName;
                _form.FieldName = form.FieldName;
                _form.Order = form.Order;
                _form.IsRequired = form.IsRequired;
                _form.IsEnabled = form.IsEnabled;
                _form.IsVisible = form.IsVisible;
                _form.CreatedDate = DateTime.Now;
                _form.CreatedBy = _username;
                _form.ModifiedDate = DateTime.Now;
                _form.ModifiedBy = _username;

                await _formRepository.AddAsync(_form);
            }
            catch (Exception ex)
            {
                Log.Error("CreateFormAsync failed:" + ex.Message);
            }
        }

        public async Task<FormItemViewModel> GetFormItem(string formname, string fieldname, int order)
        {
            await LogUsername();
            Log.Information("GetFormItem started by:" + _username);

            try
            {
                var filterSpecification = new FormFilterSpecification(formname, fieldname, order);

                var items = await _formRepository.ListAsync(filterSpecification);

                var vm = new FormItemViewModel()
                {
                    Id = 0,
                    FormName = string.Empty,
                    FieldName = string.Empty,
                    Order = 0,
                    IsRequired = false,
                    IsEnabled = true,
                    IsVisible = true,
                    CreatedDate = DateTime.Now,
                    CreatedBy = _username,
                    ModifiedDate = DateTime.Now,
                    ModifiedBy = _username
                };

                if (items != null && items.Count() > 0)
                {
                    var form = items.First();

                    vm = new FormItemViewModel()
                    {
                        Id = form.Id,
                        FormName = form.FormName,
                        FieldName = form.FieldName,
                        Order = form.Order,
                        IsRequired = form.IsRequired,
                        IsEnabled = form.IsEnabled,
                        IsVisible = form.IsVisible,
                        CreatedDate = form.CreatedDate,
                        CreatedBy = form.CreatedBy,
                        ModifiedDate = form.ModifiedDate,
                        ModifiedBy = form.ModifiedBy
                    };
                }

                return vm;
            }
            catch (Exception ex)
            {
                Log.Error("GetFormItem failed:" + ex.Message);

                var vm = new FormItemViewModel();

                return vm;
            }
        }
    }
}
