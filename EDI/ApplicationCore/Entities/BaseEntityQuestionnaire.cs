using System;
using System.ComponentModel.DataAnnotations;

namespace EDI.ApplicationCore.Entities
{
    // This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
    // Using non-generic integer types for simplicity and to ease caching logic
    public class BaseEntityQuestionnaire:BaseEntity
    {
        public string LanguageCompleted { get; set; }
        public int? YearId { get; set; }
    }
}
