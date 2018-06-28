# Custom Block Helpers
> These helpers all return an updated context and pass that context into a nested template. These also all support an else condition in the case where the operation either failed or returned false. 
>
> ---
>
> **Context**
>``` json
>{
>   "value": "something wicked this way comes"
>}
>```
> ---
> **Example 1:** Showing conditional if/else style logic 
>``` handlebars
><div>
>   {{#Helpers.String.Contains value "this"}}
>       <strong>True</strong>
>   {{else}}
>       <strong>False</strong>
>   {{/Helpers.String.Contains}}
></div>
>```
>would return
>``` html
><div>
>   <strong>True</strong>
></div>
>```
> ---
> **Example 2:** Showing how context gets passed around
>``` handlebars
><ul>
>   {{#Helpers.String.Split value " "}}
>       {{#each this}}
>           <li>{{this}}</li>
>       {{/each}}
>   {{else}}
>       <li>NOTHING FOUND</li>
>   {{/Helpers.String.Split}}
></ul>
>```
>would return
>``` html
> <ul>
>     <li>something</li>
>     <li>wicked</li>
>     <li>this</li>
>     <li>way</li>
>     <li>comes</li>
> </ul>
>```

---
* [Object](customBlockHelpers/object.md)
    * [Helpers.Object.Compare](customBlockHelpers/object.md#helpersobjectcompare)
    * [Helpers.Object.Filter](customBlockHelpers/object.md#helpersobjectfilter)
    * [Helpers.Object.Lookup](customBlockHelpers/object.md#helpersobjectlookup)
* [Path](customBlockHelpers/path.md)
    * [Helpers.Path.GetKeyValuePairMatches](customBlockHelpers/path.md#helperspathgetkeyvaluepairmatches)
    * [Helpers.Path.HasExtension](customBlockHelpers/path.md#helperspathhasextension)
    * [Helpers.Path.HasKeyValuePairMatch](customBlockHelpers/path.md#helperspathhaskeyvaluepairmatch)
    * [Helpers.Path.HasSegment](customBlockHelpers/path.md#helperspathhassegment)
    * [Helpers.Path.ParseUnitSlug](customBlockHelpers/path.md#helperspathparseunitslug)
* [Regex](customBlockHelpers/regex.md)
    * [Helpers.Regex.IsMatch](customBlockHelpers/regex.md#helpersregexismatch)
* [String](customBlockHelpers/string.md)
    * [Helpers.String.Contains](customBlockHelpers/string.md#helpersstringcontains)
    * [Helpers.String.EndsWith](customBlockHelpers/string.md#helpersstringendswith)
    * [Helpers.String.IsString](customBlockHelpers/string.md#helpersstringisstring)
    * [Helpers.String.Split](customBlockHelpers/string.md#helpersstringsplit)
    * [Helpers.String.StartsWith](customBlockHelpers/string.md#helpersstringstartswith)