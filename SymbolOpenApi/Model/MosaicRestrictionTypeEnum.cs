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
using OpenAPIDateConverter = SymbolOpenApi.Client.OpenAPIDateConverter;

namespace SymbolOpenApi.Model
{
    /// <summary>
    /// Type of mosaic restriction. * 0 - Uninitialized value indicating no restriction. * 1 (EQ) - Allow if equal. * 2 (NE) - Allow if not equal. * 3 (LT) - Allow if less than. * 4 (LE) - Allow if less than or equal. * 5 (GT) - Allow if greater than. * 6 (GE) - Allow if greater than or equal. 
    /// </summary>
    /// <value>Type of mosaic restriction. * 0 - Uninitialized value indicating no restriction. * 1 (EQ) - Allow if equal. * 2 (NE) - Allow if not equal. * 3 (LT) - Allow if less than. * 4 (LE) - Allow if less than or equal. * 5 (GT) - Allow if greater than. * 6 (GE) - Allow if greater than or equal. </value>
    
    public enum MosaicRestrictionTypeEnum
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        NUMBER_0 = 0,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        NUMBER_1 = 1,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        NUMBER_2 = 2,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        NUMBER_3 = 3,

        /// <summary>
        /// Enum NUMBER_4 for value: 4
        /// </summary>
        NUMBER_4 = 4,

        /// <summary>
        /// Enum NUMBER_5 for value: 5
        /// </summary>
        NUMBER_5 = 5,

        /// <summary>
        /// Enum NUMBER_6 for value: 6
        /// </summary>
        NUMBER_6 = 6

    }

}
