// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
using System.Text.Json.Serialization.Metadata;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// FormatTest
    /// </summary>
    public partial class FormatTest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormatTest" /> class.
        /// </summary>
        /// <param name="byte">byte</param>
        /// <param name="date">date</param>
        /// <param name="number">number</param>
        /// <param name="password">password</param>
        /// <param name="binary">binary</param>
        /// <param name="dateTime">dateTime</param>
        /// <param name="decimal">decimal</param>
        /// <param name="double">double</param>
        /// <param name="float">float</param>
        /// <param name="int32">int32</param>
        /// <param name="int64">int64</param>
        /// <param name="integer">integer</param>
        /// <param name="patternWithBackslash">None</param>
        /// <param name="patternWithDigits">A string that is a 10 digit number. Can have leading zeros.</param>
        /// <param name="patternWithDigitsAndDelimiter">A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</param>
        /// <param name="string">string</param>
        /// <param name="unsignedInteger">unsignedInteger</param>
        /// <param name="unsignedLong">unsignedLong</param>
        /// <param name="uuid">uuid</param>
        [JsonConstructor]
        public FormatTest(byte[] @byte, DateOnly date, decimal number, string password, Option<System.IO.Stream?> binary = default, Option<DateTime?> dateTime = default, Option<decimal?> @decimal = default, Option<double?> @double = default, Option<float?> @float = default, Option<int?> int32 = default, Option<long?> int64 = default, Option<int?> integer = default, Option<string?> patternWithBackslash = default, Option<string?> patternWithDigits = default, Option<string?> patternWithDigitsAndDelimiter = default, Option<string?> @string = default, Option<uint?> unsignedInteger = default, Option<ulong?> unsignedLong = default, Option<Guid?> uuid = default)
        {
            Byte = @byte;
            Date = date;
            Number = number;
            Password = password;
            BinaryOption = binary;
            DateTimeOption = dateTime;
            DecimalOption = @decimal;
            DoubleOption = @double;
            FloatOption = @float;
            Int32Option = int32;
            Int64Option = int64;
            IntegerOption = integer;
            PatternWithBackslashOption = patternWithBackslash;
            PatternWithDigitsOption = patternWithDigits;
            PatternWithDigitsAndDelimiterOption = patternWithDigitsAndDelimiter;
            StringOption = @string;
            UnsignedIntegerOption = unsignedInteger;
            UnsignedLongOption = unsignedLong;
            UuidOption = uuid;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Byte
        /// </summary>
        [JsonPropertyName("byte")]
        public byte[] Byte { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /// <example>Sun Feb 02 00:00:00 UTC 2020</example>
        [JsonPropertyName("date")]
        public DateOnly Date { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [JsonPropertyName("number")]
        public decimal Number { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Used to track the state of Binary
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<System.IO.Stream?> BinaryOption { get; private set; }

        /// <summary>
        /// Gets or Sets Binary
        /// </summary>
        [JsonPropertyName("binary")]
        public System.IO.Stream? Binary { get { return this.BinaryOption; } set { this.BinaryOption = new(value); } }

        /// <summary>
        /// Used to track the state of DateTime
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> DateTimeOption { get; private set; }

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        /// <example>2007-12-03T10:15:30+01:00</example>
        [JsonPropertyName("dateTime")]
        public DateTime? DateTime { get { return this.DateTimeOption; } set { this.DateTimeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Decimal
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> DecimalOption { get; private set; }

        /// <summary>
        /// Gets or Sets Decimal
        /// </summary>
        [JsonPropertyName("decimal")]
        public decimal? Decimal { get { return this.DecimalOption; } set { this.DecimalOption = new(value); } }

        /// <summary>
        /// Used to track the state of Double
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> DoubleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [JsonPropertyName("double")]
        public double? Double { get { return this.DoubleOption; } set { this.DoubleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Float
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<float?> FloatOption { get; private set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [JsonPropertyName("float")]
        public float? Float { get { return this.FloatOption; } set { this.FloatOption = new(value); } }

        /// <summary>
        /// Used to track the state of Int32
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> Int32Option { get; private set; }

        /// <summary>
        /// Gets or Sets Int32
        /// </summary>
        [JsonPropertyName("int32")]
        public int? Int32 { get { return this.Int32Option; } set { this.Int32Option = new(value); } }

        /// <summary>
        /// Used to track the state of Int64
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> Int64Option { get; private set; }

        /// <summary>
        /// Gets or Sets Int64
        /// </summary>
        [JsonPropertyName("int64")]
        public long? Int64 { get { return this.Int64Option; } set { this.Int64Option = new(value); } }

        /// <summary>
        /// Used to track the state of Integer
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> IntegerOption { get; private set; }

        /// <summary>
        /// Gets or Sets Integer
        /// </summary>
        [JsonPropertyName("integer")]
        public int? Integer { get { return this.IntegerOption; } set { this.IntegerOption = new(value); } }

        /// <summary>
        /// Used to track the state of PatternWithBackslash
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PatternWithBackslashOption { get; private set; }

        /// <summary>
        /// None
        /// </summary>
        /// <value>None</value>
        [JsonPropertyName("pattern_with_backslash")]
        public string? PatternWithBackslash { get { return this.PatternWithBackslashOption; } set { this.PatternWithBackslashOption = new(value); } }

        /// <summary>
        /// Used to track the state of PatternWithDigits
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PatternWithDigitsOption { get; private set; }

        /// <summary>
        /// A string that is a 10 digit number. Can have leading zeros.
        /// </summary>
        /// <value>A string that is a 10 digit number. Can have leading zeros.</value>
        [JsonPropertyName("pattern_with_digits")]
        public string? PatternWithDigits { get { return this.PatternWithDigitsOption; } set { this.PatternWithDigitsOption = new(value); } }

        /// <summary>
        /// Used to track the state of PatternWithDigitsAndDelimiter
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PatternWithDigitsAndDelimiterOption { get; private set; }

        /// <summary>
        /// A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.
        /// </summary>
        /// <value>A string starting with &#39;image_&#39; (case insensitive) and one to three digits following i.e. Image_01.</value>
        [JsonPropertyName("pattern_with_digits_and_delimiter")]
        public string? PatternWithDigitsAndDelimiter { get { return this.PatternWithDigitsAndDelimiterOption; } set { this.PatternWithDigitsAndDelimiterOption = new(value); } }

        /// <summary>
        /// Used to track the state of String
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StringOption { get; private set; }

        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [JsonPropertyName("string")]
        public string? String { get { return this.StringOption; } set { this.StringOption = new(value); } }

        /// <summary>
        /// Used to track the state of UnsignedInteger
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<uint?> UnsignedIntegerOption { get; private set; }

        /// <summary>
        /// Gets or Sets UnsignedInteger
        /// </summary>
        [JsonPropertyName("unsigned_integer")]
        public uint? UnsignedInteger { get { return this.UnsignedIntegerOption; } set { this.UnsignedIntegerOption = new(value); } }

        /// <summary>
        /// Used to track the state of UnsignedLong
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<ulong?> UnsignedLongOption { get; private set; }

        /// <summary>
        /// Gets or Sets UnsignedLong
        /// </summary>
        [JsonPropertyName("unsigned_long")]
        public ulong? UnsignedLong { get { return this.UnsignedLongOption; } set { this.UnsignedLongOption = new(value); } }

        /// <summary>
        /// Used to track the state of Uuid
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Guid?> UuidOption { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        /// <example>72f98069-206d-4f12-9f12-3d1e525a8e84</example>
        [JsonPropertyName("uuid")]
        public Guid? Uuid { get { return this.UuidOption; } set { this.UuidOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FormatTest {\n");
            sb.Append("  Byte: ").Append(Byte).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Binary: ").Append(Binary).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Decimal: ").Append(Decimal).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Int32: ").Append(Int32).Append("\n");
            sb.Append("  Int64: ").Append(Int64).Append("\n");
            sb.Append("  Integer: ").Append(Integer).Append("\n");
            sb.Append("  PatternWithBackslash: ").Append(PatternWithBackslash).Append("\n");
            sb.Append("  PatternWithDigits: ").Append(PatternWithDigits).Append("\n");
            sb.Append("  PatternWithDigitsAndDelimiter: ").Append(PatternWithDigitsAndDelimiter).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  UnsignedInteger: ").Append(UnsignedInteger).Append("\n");
            sb.Append("  UnsignedLong: ").Append(UnsignedLong).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Number (decimal) maximum
            if (this.Number > (decimal)543.2)
            {
                yield return new ValidationResult("Invalid value for Number, must be a value less than or equal to 543.2.", new [] { "Number" });
            }

            // Number (decimal) minimum
            if (this.Number < (decimal)32.1)
            {
                yield return new ValidationResult("Invalid value for Number, must be a value greater than or equal to 32.1.", new [] { "Number" });
            }

            // Password (string) maxLength
            if (this.Password != null && this.Password.Length > 64)
            {
                yield return new ValidationResult("Invalid value for Password, length must be less than 64.", new [] { "Password" });
            }

            // Password (string) minLength
            if (this.Password != null && this.Password.Length < 10)
            {
                yield return new ValidationResult("Invalid value for Password, length must be greater than 10.", new [] { "Password" });
            }

            // Double (double) maximum
            if (this.DoubleOption.IsSet && this.DoubleOption.Value > (double)123.4)
            {
                yield return new ValidationResult("Invalid value for Double, must be a value less than or equal to 123.4.", new [] { "Double" });
            }

            // Double (double) minimum
            if (this.DoubleOption.IsSet && this.DoubleOption.Value < (double)67.8)
            {
                yield return new ValidationResult("Invalid value for Double, must be a value greater than or equal to 67.8.", new [] { "Double" });
            }

            // Float (float) maximum
            if (this.FloatOption.IsSet && this.FloatOption.Value > (float)987.6)
            {
                yield return new ValidationResult("Invalid value for Float, must be a value less than or equal to 987.6.", new [] { "Float" });
            }

            // Float (float) minimum
            if (this.FloatOption.IsSet && this.FloatOption.Value < (float)54.3)
            {
                yield return new ValidationResult("Invalid value for Float, must be a value greater than or equal to 54.3.", new [] { "Float" });
            }

            // Int32 (int) maximum
            if (this.Int32Option.IsSet && this.Int32Option.Value > (int)200)
            {
                yield return new ValidationResult("Invalid value for Int32, must be a value less than or equal to 200.", new [] { "Int32" });
            }

            // Int32 (int) minimum
            if (this.Int32Option.IsSet && this.Int32Option.Value < (int)20)
            {
                yield return new ValidationResult("Invalid value for Int32, must be a value greater than or equal to 20.", new [] { "Int32" });
            }

            // Integer (int) maximum
            if (this.IntegerOption.IsSet && this.IntegerOption.Value > (int)100)
            {
                yield return new ValidationResult("Invalid value for Integer, must be a value less than or equal to 100.", new [] { "Integer" });
            }

            // Integer (int) minimum
            if (this.IntegerOption.IsSet && this.IntegerOption.Value < (int)10)
            {
                yield return new ValidationResult("Invalid value for Integer, must be a value greater than or equal to 10.", new [] { "Integer" });
            }

            if (this.PatternWithBackslashOption.Value != null) {
                // PatternWithBackslash (string) pattern
                Regex regexPatternWithBackslash = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\/([0-9]|[1-2][0-9]|3[0-2]))$", RegexOptions.CultureInvariant);

                if (this.PatternWithBackslashOption.Value != null &&!regexPatternWithBackslash.Match(this.PatternWithBackslashOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithBackslash, must match a pattern of " + regexPatternWithBackslash, new [] { "PatternWithBackslash" });
                }
            }

            if (this.PatternWithDigitsOption.Value != null) {
                // PatternWithDigits (string) pattern
                Regex regexPatternWithDigits = new Regex(@"^\d{10}$", RegexOptions.CultureInvariant);

                if (this.PatternWithDigitsOption.Value != null &&!regexPatternWithDigits.Match(this.PatternWithDigitsOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigits, must match a pattern of " + regexPatternWithDigits, new [] { "PatternWithDigits" });
                }
            }

            if (this.PatternWithDigitsAndDelimiterOption.Value != null) {
                // PatternWithDigitsAndDelimiter (string) pattern
                Regex regexPatternWithDigitsAndDelimiter = new Regex(@"^image_\d{1,3}$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

                if (this.PatternWithDigitsAndDelimiterOption.Value != null &&!regexPatternWithDigitsAndDelimiter.Match(this.PatternWithDigitsAndDelimiterOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PatternWithDigitsAndDelimiter, must match a pattern of " + regexPatternWithDigitsAndDelimiter, new [] { "PatternWithDigitsAndDelimiter" });
                }
            }

            if (this.StringOption.Value != null) {
                // String (string) pattern
                Regex regexString = new Regex(@"[a-z]", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

                if (this.StringOption.Value != null &&!regexString.Match(this.StringOption.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for String, must match a pattern of " + regexString, new [] { "String" });
                }
            }

            // UnsignedInteger (uint) maximum
            if (this.UnsignedIntegerOption.IsSet && this.UnsignedIntegerOption.Value > (uint)200)
            {
                yield return new ValidationResult("Invalid value for UnsignedInteger, must be a value less than or equal to 200.", new [] { "UnsignedInteger" });
            }

            // UnsignedInteger (uint) minimum
            if (this.UnsignedIntegerOption.IsSet && this.UnsignedIntegerOption.Value < (uint)20)
            {
                yield return new ValidationResult("Invalid value for UnsignedInteger, must be a value greater than or equal to 20.", new [] { "UnsignedInteger" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FormatTest" />
    /// </summary>
    public class FormatTestJsonConverter : JsonConverter<FormatTest>
    {
        /// <summary>
        /// The format to use to serialize Date
        /// </summary>
        public static string DateFormat { get; set; } = "yyyy'-'MM'-'dd";

        /// <summary>
        /// The format to use to serialize DateTime
        /// </summary>
        public static string DateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="FormatTest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FormatTest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<byte[]?> varByte = default;
            Option<DateOnly?> date = default;
            Option<decimal?> number = default;
            Option<string?> password = default;
            Option<System.IO.Stream?> binary = default;
            Option<DateTime?> dateTime = default;
            Option<decimal?> varDecimal = default;
            Option<double?> varDouble = default;
            Option<float?> varFloat = default;
            Option<int?> int32 = default;
            Option<long?> int64 = default;
            Option<int?> integer = default;
            Option<string?> patternWithBackslash = default;
            Option<string?> patternWithDigits = default;
            Option<string?> patternWithDigitsAndDelimiter = default;
            Option<string?> varString = default;
            Option<uint?> unsignedInteger = default;
            Option<ulong?> unsignedLong = default;
            Option<Guid?> uuid = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "byte":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varByte = new Option<byte[]?>(JsonSerializer.Deserialize<byte[]>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "date":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                date = new Option<DateOnly?>(JsonSerializer.Deserialize<DateOnly>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "number":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                number = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "password":
                            password = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "binary":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                binary = new Option<System.IO.Stream?>(JsonSerializer.Deserialize<System.IO.Stream>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "dateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "decimal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varDecimal = new Option<decimal?>(JsonSerializer.Deserialize<decimal>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "double":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varDouble = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "float":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                varFloat = new Option<float?>((float)utf8JsonReader.GetDouble());
                            break;
                        case "int32":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                int32 = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "int64":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                int64 = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                integer = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "pattern_with_backslash":
                            patternWithBackslash = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "pattern_with_digits":
                            patternWithDigits = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "pattern_with_digits_and_delimiter":
                            patternWithDigitsAndDelimiter = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "string":
                            varString = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "unsigned_integer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                unsignedInteger = new Option<uint?>(utf8JsonReader.GetUInt32());
                            break;
                        case "unsigned_long":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                unsignedLong = new Option<ulong?>(utf8JsonReader.GetUInt64());
                            break;
                        case "uuid":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uuid = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!varByte.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(varByte));

            if (!date.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(date));

            if (!number.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(number));

            if (!password.IsSet)
                throw new ArgumentException("Property is required for class FormatTest.", nameof(password));

            if (varByte.IsSet && varByte.Value == null)
                throw new ArgumentNullException(nameof(varByte), "Property is not nullable for class FormatTest.");

            if (date.IsSet && date.Value == null)
                throw new ArgumentNullException(nameof(date), "Property is not nullable for class FormatTest.");

            if (number.IsSet && number.Value == null)
                throw new ArgumentNullException(nameof(number), "Property is not nullable for class FormatTest.");

            if (password.IsSet && password.Value == null)
                throw new ArgumentNullException(nameof(password), "Property is not nullable for class FormatTest.");

            if (binary.IsSet && binary.Value == null)
                throw new ArgumentNullException(nameof(binary), "Property is not nullable for class FormatTest.");

            if (dateTime.IsSet && dateTime.Value == null)
                throw new ArgumentNullException(nameof(dateTime), "Property is not nullable for class FormatTest.");

            if (varDecimal.IsSet && varDecimal.Value == null)
                throw new ArgumentNullException(nameof(varDecimal), "Property is not nullable for class FormatTest.");

            if (varDouble.IsSet && varDouble.Value == null)
                throw new ArgumentNullException(nameof(varDouble), "Property is not nullable for class FormatTest.");

            if (varFloat.IsSet && varFloat.Value == null)
                throw new ArgumentNullException(nameof(varFloat), "Property is not nullable for class FormatTest.");

            if (int32.IsSet && int32.Value == null)
                throw new ArgumentNullException(nameof(int32), "Property is not nullable for class FormatTest.");

            if (int64.IsSet && int64.Value == null)
                throw new ArgumentNullException(nameof(int64), "Property is not nullable for class FormatTest.");

            if (integer.IsSet && integer.Value == null)
                throw new ArgumentNullException(nameof(integer), "Property is not nullable for class FormatTest.");

            if (patternWithBackslash.IsSet && patternWithBackslash.Value == null)
                throw new ArgumentNullException(nameof(patternWithBackslash), "Property is not nullable for class FormatTest.");

            if (patternWithDigits.IsSet && patternWithDigits.Value == null)
                throw new ArgumentNullException(nameof(patternWithDigits), "Property is not nullable for class FormatTest.");

            if (patternWithDigitsAndDelimiter.IsSet && patternWithDigitsAndDelimiter.Value == null)
                throw new ArgumentNullException(nameof(patternWithDigitsAndDelimiter), "Property is not nullable for class FormatTest.");

            if (varString.IsSet && varString.Value == null)
                throw new ArgumentNullException(nameof(varString), "Property is not nullable for class FormatTest.");

            if (unsignedInteger.IsSet && unsignedInteger.Value == null)
                throw new ArgumentNullException(nameof(unsignedInteger), "Property is not nullable for class FormatTest.");

            if (unsignedLong.IsSet && unsignedLong.Value == null)
                throw new ArgumentNullException(nameof(unsignedLong), "Property is not nullable for class FormatTest.");

            if (uuid.IsSet && uuid.Value == null)
                throw new ArgumentNullException(nameof(uuid), "Property is not nullable for class FormatTest.");

            return new FormatTest(varByte.Value!, date.Value!.Value!, number.Value!.Value!, password.Value!, binary, dateTime, varDecimal, varDouble, varFloat, int32, int64, integer, patternWithBackslash, patternWithDigits, patternWithDigitsAndDelimiter, varString, unsignedInteger, unsignedLong, uuid);
        }

        /// <summary>
        /// Serializes a <see cref="FormatTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="formatTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FormatTest formatTest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, formatTest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FormatTest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="formatTest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FormatTest formatTest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (formatTest.Byte == null)
                throw new ArgumentNullException(nameof(formatTest.Byte), "Property is required for class FormatTest.");

            if (formatTest.Password == null)
                throw new ArgumentNullException(nameof(formatTest.Password), "Property is required for class FormatTest.");

            if (formatTest.BinaryOption.IsSet && formatTest.Binary == null)
                throw new ArgumentNullException(nameof(formatTest.Binary), "Property is required for class FormatTest.");

            if (formatTest.PatternWithBackslashOption.IsSet && formatTest.PatternWithBackslash == null)
                throw new ArgumentNullException(nameof(formatTest.PatternWithBackslash), "Property is required for class FormatTest.");

            if (formatTest.PatternWithDigitsOption.IsSet && formatTest.PatternWithDigits == null)
                throw new ArgumentNullException(nameof(formatTest.PatternWithDigits), "Property is required for class FormatTest.");

            if (formatTest.PatternWithDigitsAndDelimiterOption.IsSet && formatTest.PatternWithDigitsAndDelimiter == null)
                throw new ArgumentNullException(nameof(formatTest.PatternWithDigitsAndDelimiter), "Property is required for class FormatTest.");

            if (formatTest.StringOption.IsSet && formatTest.String == null)
                throw new ArgumentNullException(nameof(formatTest.String), "Property is required for class FormatTest.");

            writer.WritePropertyName("byte");
            JsonSerializer.Serialize(writer, formatTest.Byte, jsonSerializerOptions);
            writer.WriteString("date", formatTest.Date.ToString(DateFormat));

            writer.WriteNumber("number", formatTest.Number);

            writer.WriteString("password", formatTest.Password);

            if (formatTest.BinaryOption.IsSet)
            {
                writer.WritePropertyName("binary");
                JsonSerializer.Serialize(writer, formatTest.Binary, jsonSerializerOptions);
            }
            if (formatTest.DateTimeOption.IsSet)
                writer.WriteString("dateTime", formatTest.DateTimeOption.Value!.Value.ToString(DateTimeFormat));

            if (formatTest.DecimalOption.IsSet)
            {
                writer.WritePropertyName("decimal");
                JsonSerializer.Serialize(writer, formatTest.Decimal, jsonSerializerOptions);
            }
            if (formatTest.DoubleOption.IsSet)
                writer.WriteNumber("double", formatTest.DoubleOption.Value!.Value);

            if (formatTest.FloatOption.IsSet)
                writer.WriteNumber("float", formatTest.FloatOption.Value!.Value);

            if (formatTest.Int32Option.IsSet)
                writer.WriteNumber("int32", formatTest.Int32Option.Value!.Value);

            if (formatTest.Int64Option.IsSet)
                writer.WriteNumber("int64", formatTest.Int64Option.Value!.Value);

            if (formatTest.IntegerOption.IsSet)
                writer.WriteNumber("integer", formatTest.IntegerOption.Value!.Value);

            if (formatTest.PatternWithBackslashOption.IsSet)
                writer.WriteString("pattern_with_backslash", formatTest.PatternWithBackslash);

            if (formatTest.PatternWithDigitsOption.IsSet)
                writer.WriteString("pattern_with_digits", formatTest.PatternWithDigits);

            if (formatTest.PatternWithDigitsAndDelimiterOption.IsSet)
                writer.WriteString("pattern_with_digits_and_delimiter", formatTest.PatternWithDigitsAndDelimiter);

            if (formatTest.StringOption.IsSet)
                writer.WriteString("string", formatTest.String);

            if (formatTest.UnsignedIntegerOption.IsSet)
                writer.WriteNumber("unsigned_integer", formatTest.UnsignedIntegerOption.Value!.Value);

            if (formatTest.UnsignedLongOption.IsSet)
                writer.WriteNumber("unsigned_long", formatTest.UnsignedLongOption.Value!.Value);

            if (formatTest.UuidOption.IsSet)
                writer.WriteString("uuid", formatTest.UuidOption.Value!.Value);
        }
    }

    /// <summary>
    /// The FormatTestSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(FormatTest))]
    public partial class FormatTestSerializationContext : JsonSerializerContext { }
}
