﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EDI.ApplicationCore.Entities
{
    public partial class DateDimension
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public byte Day { get; set; }

        [Required]
        [StringLength(2)]
        public string DaySuffix { get; set; }

        public byte Weekday { get; set; }

        [Required]
        [StringLength(10)]
        public string WeekDayName { get; set; }

        public bool IsWeekend { get; set; }

        public bool IsHoliday { get; set; }

        [StringLength(64)]
        public string HolidayText { get; set; }

        public byte DOWInMonth { get; set; }

        public short DayOfYear { get; set; }

        public byte WeekOfMonth { get; set; }

        public byte WeekOfYear { get; set; }

        public byte ISOWeekOfYear { get; set; }

        public byte Month { get; set; }

        [Required]
        [StringLength(10)]
        public string MonthName { get; set; }

        public byte Quarter { get; set; }

        [Required]
        [StringLength(6)]
        public string QuarterName { get; set; }

        public int Year { get; set; }

        public int YearMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDayOfMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDayOfMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDayOfQuarter { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDayOfQuarter { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDayOfYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime LastDayOfYear { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDayOfNextMonth { get; set; }

        [Column(TypeName = "date")]
        public DateTime FirstDayOfNextYear { get; set; }

        public int FiscalYear { get; set; }

        public int FiscalYearMonth { get; set; }

        public int FiscalYearMonthOrder { get; set; }
    }
}
