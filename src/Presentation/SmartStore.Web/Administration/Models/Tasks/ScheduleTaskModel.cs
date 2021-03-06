﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FluentValidation.Attributes;
using SmartStore.Admin.Validators.Tasks;
using SmartStore.Web.Framework;
using SmartStore.Web.Framework.Modelling;

namespace SmartStore.Admin.Models.Tasks
{
    [Validator(typeof(ScheduleTaskValidator))]
    public partial class ScheduleTaskModel : EntityModelBase
    {
        [SmartResourceDisplayName("Admin.System.ScheduleTasks.Name")]
        [AllowHtml]
        public string Name { get; set; }

		[SmartResourceDisplayName("Admin.System.ScheduleTasks.CronExpression")]
		public string CronExpression { get; set; }
		public string CronDescription { get; set; }
		
        [SmartResourceDisplayName("Admin.System.ScheduleTasks.Enabled")]
        public bool Enabled { get; set; }

        [SmartResourceDisplayName("Admin.System.ScheduleTasks.RunPerMachine")]
        public bool RunPerMachine { get; set; }

        [SmartResourceDisplayName("Admin.System.ScheduleTasks.StopOnError")]
        public bool StopOnError { get; set; }

        [SmartResourceDisplayName("Admin.System.ScheduleTasks.NextRun")]
		[DisplayFormat(DataFormatString = "g")]
		public DateTime? NextRun { get; set; }
        public string NextRunPretty { get; set; }

		public bool IsOverdue { get; set; }

		public string CancelUrl { get; set; }
		public string EditUrl { get; set; }
		public string ExecuteUrl { get; set; }

        public ScheduleTaskHistoryModel LastHistoryEntry { get; set; }
    }
}