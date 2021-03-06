﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Orneholm.ApplicationInsights.Web.Models
{
    public partial class Age
    {
        private double? _days;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Days
        {
            get { return this._days; }
            set { this._days = value; }
        }
        
        private double? _hours;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public double? Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Age class.
        /// </summary>
        public Age()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken daysValue = inputObject["Days"];
                if (daysValue != null && daysValue.Type != JTokenType.Null)
                {
                    this.Days = ((double)daysValue);
                }
                JToken hoursValue = inputObject["Hours"];
                if (hoursValue != null && hoursValue.Type != JTokenType.Null)
                {
                    this.Hours = ((double)hoursValue);
                }
            }
        }
    }
}
