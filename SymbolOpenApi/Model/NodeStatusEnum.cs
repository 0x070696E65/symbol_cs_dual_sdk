/*
 * Catapult REST Endpoints
 *
 * OpenAPI Specification of catapult-rest
 *
 * The version of the OpenAPI document: 1.0.4
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines NodeStatusEnum
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum NodeStatusEnum
    {
        /// <summary>
        /// Enum Up for value: up
        /// </summary>
        [EnumMember(Value = "up")]
        Up = 1,

        /// <summary>
        /// Enum Down for value: down
        /// </summary>
        [EnumMember(Value = "down")]
        Down = 2

    }

}
