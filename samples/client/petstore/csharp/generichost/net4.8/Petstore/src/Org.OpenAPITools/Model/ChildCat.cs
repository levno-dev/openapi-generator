// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ChildCat
    /// </summary>
    public partial class ChildCat : ParentPet, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildCat" /> class.
        /// </summary>
        /// <param name="name">name</param>
        [JsonConstructor]
        public ChildCat(Option<string> name = default) : base()
        {
            NameOption = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines PetType
        /// </summary>
        public enum PetTypeEnum
        {
            /// <summary>
            /// Enum ChildCat for value: ChildCat
            /// </summary>
            ChildCat = 1
        }

        /// <summary>
        /// Returns a <see cref="PetTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static PetTypeEnum PetTypeEnumFromString(string value)
        {
            if (value.Equals("ChildCat"))
                return PetTypeEnum.ChildCat;

            throw new NotImplementedException($"Could not convert value to type PetTypeEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="PetTypeEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static PetTypeEnum? PetTypeEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ChildCat"))
                return PetTypeEnum.ChildCat;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="PetTypeEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string PetTypeEnumToJsonValue(PetTypeEnum value)
        {
            if (value == PetTypeEnum.ChildCat)
                return "ChildCat";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get { return this.NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// The discriminator
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public new PetTypeEnum PetType { get; } = (PetTypeEnum)Enum.Parse(typeof(PetTypeEnum), "ChildCat");

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChildCat {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ChildCat" />
    /// </summary>
    public class ChildCatJsonConverter : JsonConverter<ChildCat>
    {
        /// <summary>
        /// Deserializes json to <see cref="ChildCat" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ChildCat Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> name = default;
            Option<ChildCat.PetTypeEnum?> petType = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "pet_type":
                            string petTypeRawValue = utf8JsonReader.GetString();
                            if (petTypeRawValue != null)
                                petType = new Option<ChildCat.PetTypeEnum?>(ChildCat.PetTypeEnumFromStringOrDefault(petTypeRawValue));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!petType.IsSet)
                throw new ArgumentException("Property is required for class ChildCat.", nameof(petType));

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class ChildCat.");

            if (petType.IsSet && petType.Value == null)
                throw new ArgumentNullException(nameof(petType), "Property is not nullable for class ChildCat.");

            return new ChildCat(name);
        }

        /// <summary>
        /// Serializes a <see cref="ChildCat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="childCat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ChildCat childCat, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, childCat, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ChildCat" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="childCat"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ChildCat childCat, JsonSerializerOptions jsonSerializerOptions)
        {
            if (childCat.NameOption.IsSet && childCat.Name == null)
                throw new ArgumentNullException(nameof(childCat.Name), "Property is required for class ChildCat.");

            if (childCat.NameOption.IsSet)
                writer.WriteString("name", childCat.Name);

            writer.WriteString("pet_type", ChildCat.PetTypeEnumToJsonValue(childCat.PetType));
        }
    }
}
