//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"
#pragma warning disable 8625 // Disable "CS8625 Cannot convert null literal to non-nullable reference type"

namespace LinguaNex.Blazor.Dto
{
    using System = global::System;

    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record SupportedCulture
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("englishName")]
        public string EnglishName { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CreateCultureDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("syncResource")]
        public bool? SyncResource { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("translate")]
        public bool? Translate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("translateProvider")]
        public TranslateProviderEnum TranslateProvider { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CultureDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ResourcesDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("cultureName")]
        public string CultureName { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("resources")]
        public System.Collections.Generic.IDictionary<string, string> Resources { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum TranslateProviderEnum
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record AssociationProjectsDto
    {
        /// <summary>
        /// 可关联项目列表
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("canAssociationProjects")]
        public System.Collections.Generic.ICollection<ProjectDto> CanAssociationProjects { get; set; }

        /// <summary>
        /// 已关联项目列表
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("hasAssociationProjects")]
        public System.Collections.Generic.ICollection<ProjectDto> HasAssociationProjects { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CreateProjectAssociationDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("mainProjectId")]
        public string MainProjectId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("associationProjectIds")]
        public System.Collections.Generic.ICollection<string> AssociationProjectIds { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CreateProjectDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("enalbe")]
        public bool Enalbe { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record DeleteProjectAssociationDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("mainProjectId")]
        public string MainProjectId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("associationProjectId")]
        public string AssociationProjectId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ProjectDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("enalbe")]
        public bool Enalbe { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record AntdColumn
    {

        [System.Text.Json.Serialization.JsonPropertyName("dataIndex")]
        public string DataIndex { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("shortTitle")]
        public string ShortTitle { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record BatchCreateWithoutTransateDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public string Key { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("resouces")]
        public System.Collections.Generic.ICollection<BatchCreateWithoutTransateResourceDto> Resouces { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record BatchCreateWithoutTransateResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cultureId")]
        public string CultureId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record BatchUpdateDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cultureId")]
        public string CultureId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record BatchUpdateResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public string Key { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("resouces")]
        public System.Collections.Generic.ICollection<BatchUpdateDto> Resouces { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CreateResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public string Key { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cultureId")]
        public string CultureId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("syncCulture")]
        public bool? SyncCulture { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("translate")]
        public bool? Translate { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("translateProvider")]
        public TranslateProviderEnum TranslateProvider { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CultureResourceAllInOneDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("columns")]
        public System.Collections.Generic.ICollection<AntdColumn> Columns { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("resources")]
        public System.Collections.Generic.ICollection<System.Collections.Generic.IDictionary<string, string>> Resources { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record CultureResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("cultureId")]
        public string? CultureId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public string Key { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("cultureId")]
        public string CultureId { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record TransateMultipleLanguagesDto
    {
        /// <summary>
        /// 项目Id
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("projectId")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 源字符串语言
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("sourceLanguage")]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// 翻译内容
        /// </summary>

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("translateProvider")]
        public TranslateProviderEnum TranslateProvider { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record UpdateResourceByCultureAndKeyDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("culture")]
        public string Culture { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("project")]
        public string Project { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("key")]
        public string Key { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record UpdateResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("value")]
        public string Value { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record PageOfCultureDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<CultureDto> Data { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public string Total { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record PageOfDictionaryOfStringAndCultureResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<System.Collections.Generic.IDictionary<string, CultureResourceDto>> Data { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public string Total { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record PageOfProjectDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<ProjectDto> Data { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public string Total { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record PageOfResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<ResourceDto> Data { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public string Total { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfAssociationProjectsDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public AssociationProjectsDto Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfCultureDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public CultureDto Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfCultureResourceAllInOneDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public CultureResourceAllInOneDto Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfDictionaryOfStringAndString
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.IDictionary<string, string> Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfListOfAntdColumn
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<AntdColumn> Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfListOfResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<ResourceDto> Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfListOfSupportedCulture
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public System.Collections.Generic.ICollection<SupportedCulture> Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfProjectDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public ProjectDto Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfResourceDto
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public ResourceDto Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record ROfString
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public string Data { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial record R
    {

        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("message")]
        public string Message { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class FileParameter
    {
        public FileParameter(System.IO.Stream data)
            : this (data, null, null)
        {
        }

        public FileParameter(System.IO.Stream data, string fileName)
            : this (data, fileName, null)
        {
        }

        public FileParameter(System.IO.Stream data, string fileName, string contentType)
        {
            Data = data;
            FileName = fileName;
            ContentType = contentType;
        }

        public System.IO.Stream Data { get; private set; }

        public string FileName { get; private set; }

        public string ContentType { get; private set; }
    }



    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LinguaNexApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public LinguaNexApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "14.0.3.0 (NJsonSchema v11.0.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class LinguaNexApiException<TResult> : LinguaNexApiException
    {
        public TResult Result { get; private set; }

        public LinguaNexApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException)
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604
#pragma warning restore 8625