# Custom Helpers
>These helpers all return values inline; when you reference one, its reference gets replaced by the resulting value.
>
>For example: 
>``` handlebars
><strong>{{Helper.String.Uppercase "some string"}}</strong>
>```
>would return 
>``` html
><strong>SOME STRING</strong>
>```
>&nbsp;
---
* [Date](customHelpers/date.md)
    * [Helpers.Date.Format](customHelpers/date.md#helpersdateformat)
    * [Helpers.Date.Today](customHelpers/date.md#helpersdatetoday)
* [HTML](customHelpers/html.md)
    * [Helpers.Html.Escape](customHelpers/html.md#helpershtmlescape)
    * [Helpers.Html.HtmlDecode](customHelpers/html.md#helpershtmlhtmldecode)
    * [Helpers.Html.HtmlEncode](customHelpers/html.md#helpershtmlhtmlencode)
* [Image](customHelpers/image.md)
    * [Helpers.Image.BuildImageUrl](customHelpers/image.md#helpersimagebuildimageurl)
    * [Helpers.Image.GetBaseImageUrl](customHelpers/image.md#helpersimagegetbaseimageurl)
* [Math](customHelpers/math.md)
    * [Helpers.Math.Add](customHelpers/math.md#helpersmathadd)
    * [Helpers.Math.Ceiling](customHelpers/math.md#helpersmathceiling)
    * [Helpers.Math.Divide](customHelpers/math.md#helpersmathdivide)
    * [Helpers.Math.Floor](customHelpers/math.md#helpersmathfloor)
    * [Helpers.Math.Mod](customHelpers/math.md#helpersmathmod)
    * [Helpers.Math.Multiply](customHelpers/math.md#helpersmathmultiply)
    * [Helpers.Math.Round](customHelpers/math.md#helpersmathround)
    * [Helpers.Math.Subtract](customHelpers/math.md#helpersmathsubtract)
* [Number](customHelpers/number.md)
    * [Helpers.Number.FormatPrice](customHelpers/number.md#helpersnumberformatprice)
* [Object](customHelpers/object.md)
    * [Helpers.Object.GetIndex](customHelpers/object.md#helpersobjectgetindex)
    * [Helpers.Object.GetLength](customHelpers/object.md#helpersobjectgetlength)
    * [Helpers.Object.Max](customHelpers/object.md#helpersobjectmax)
    * [Helpers.Object.Min](customHelpers/object.md#helpersobjectmin)
    * [Helpers.Object.ToJson](customHelpers/object.md#helpersobjecttojson)
* [Path](customHelpers/path.md)
    * [Helpers.Path.GetAbsolutePath](customHelpers/path.md#helperspathgetabsolutepath)
    * [Helpers.Path.GetDirectory](customHelpers/path.md#helperspathgetdirectory)
    * [Helpers.Path.GetExtension](customHelpers/path.md#helperspathgetextension)
    * [Helpers.Path.GetFilename](customHelpers/path.md#helperspathgetfilename)
* [String](customHelpers/string.md)
    * [Helpers.String.Append](customHelpers/string.md#helpersstringappend)
    * [Helpers.String.Ellipsis](customHelpers/string.md#helpersstringellipsis)
    * [Helpers.String.Join](customHelpers/string.md#helpersstringjoin)
    * [Helpers.String.Lowercase](customHelpers/string.md#helpersstringlowercase)
    * [Helpers.String.Occurrences](customHelpers/string.md#helpersstringoccurrences)
    * [Helpers.String.PadLeft](customHelpers/string.md#helpersstringpadleft)
    * [Helpers.String.PadRight](customHelpers/string.md#helpersstringpadright)
    * [Helpers.String.Prepend](customHelpers/string.md#helpersstringprepend)
    * [Helpers.String.Replace](customHelpers/string.md#helpersstringreplace)
    * [Helpers.String.Reverse](customHelpers/string.md#helpersstringreverse)
    * [Helpers.String.Titlecase](customHelpers/string.md#helpersstringtitlecase)
    * [Helpers.String.Trim](customHelpers/string.md#helpersstringtrim)
    * [Helpers.String.TrimLeft](customHelpers/string.md#helpersstringtrimleft)
    * [Helpers.String.TrimRight](customHelpers/string.md#helpersstringtrimright)
    * [Helpers.String.Truncate](customHelpers/string.md#helpersstringtruncate)
    * [Helpers.String.TruncateWords](customHelpers/string.md#helpersstringtruncatewords)
    * [Helpers.String.Uppercase](customHelpers/string.md#helpersstringuppercase)
* [Url](customHelpers/url.md)
    * [Helpers.Url.Base64Decode](customHelpers/url.md#helpersurlbase64decode)
    * [Helpers.Url.Base64Encode](customHelpers/url.md#helpersurlbase64encode)
    * [Helpers.Url.DecodeUri](customHelpers/url.md#helpersurldecodeuri)
    * [Helpers.Url.EncodeUri](customHelpers/url.md#helpersurlencodeuri)
    * [Helpers.Url.StripProtocol](customHelpers/url.md#helpersurlstripprotocol)
