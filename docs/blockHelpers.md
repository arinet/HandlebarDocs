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
* Object
    * [Helpers.Object.Compare](#helpersobjectcompare)
    * [Helpers.Object.Filter](#helpersobjectfilter)
    * [Helpers.Object.Lookup](#helpersobjectlookup)
* Path
    * [Helpers.Path.GetKeyValuePairMatches](#helperspathgetkeyvaluepairmatches)
    * [Helpers.Path.HasExtension](#helperspathhasextension)
    * [Helpers.Path.HasKeyValuePairMatch](#helperspathhaskeyvaluepairmatch)
    * [Helpers.Path.HasSegment](#helperspathhassegment)
    * [Helpers.Path.ParseUnitSlug](#helperspathparseunitslug)
* Regex
    * [Helpers.Regex.IsMatch](#helpersregexismatch)
* String
    * [Helpers.String.Contains](#helpersstringcontains)
    * [Helpers.String.EndsWith](#helpersstringendswith)
    * [Helpers.String.IsString](#helpersstringisstring)
    * [Helpers.String.Split](#helpersstringsplit)
    * [Helpers.String.StartsWith](#helpersstringstartswith)

---
## Helpers.Object.Compare
|||
|-|-|
|**Summary**|Compare two objects|
|**Returns**|Whether or not operation evaluates successfully|
|**Remarks**|When trying to do a numeric comparison, if both inputs are not numeric a string comparison will occur.|
|||
|**Parameters**||
|_lvalue_|Left object|
|_operatorType_|Operator to perform, if not specified will default to =.  Supported operators are =, !=, <, <=, >, >=|
|_rvalue_|Right object|

#### Example
**Context**
``` json
{
    "a": 0,
    "b": 10
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.Compare a b}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Compare}}

{{#Helpers.Object.Compare a "<" b}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Compare}}

{{#Helpers.Object.Compare b ">" "example"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Compare}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>False</strong>

<strong>True</strong>

<strong>False</strong>
```

---
## Helpers.Object.Filter
|||
|-|-|
|**Summary**|Filters an array of objects given some expression|
|**Returns**|Array of matching objects|
|**Remarks**||
|||
|**Parameters**||
|_input_|Array to filter|
|_expression_|Expression to filter by|
|_ignoreCase_|Whether or not to ignore case, defaults to false|

#### Example
**Context**
``` json
{
    "objects": [
        {
            "id": 1,
            "name": "test-1",
            "type": "thing",
            "moreData": "more",
            "meta": {
                "name": "data"
            }
        },
        {
            "id": 2,
            "name": "test-2",
            "type": "thing",
            "price": 100.0,
            "meta": {
                "name": "data"
            }
        },
        {
            "id": 3,
            "name": "test-3",
            "type": "something else"
        }
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
<ul>
    {{#Helpers.Object.Filter objects "type=thing"}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}

        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Filter}}
</ul>

<ul>
    {{#Helpers.Object.Filter objects "meta.name=data"}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}

        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Filter}}
</ul>

<ul>
    {{#Helpers.Object.Filter objects "meta.name=Data"}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}

        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Filter}}
</ul>

<ul>
    {{#Helpers.Object.Filter objects "meta.name=Data AND price > 10" true}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}

        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Filter}}
</ul>

<ul>
    {{#Helpers.Object.Filter objects "(meta.name=Data AND price > 10) OR id = 3" true}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}

        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Filter}}
</ul>
```
**Returns**
``` html
<strong>result:</strong>
<ul>
    <li>Key: id, Value: 1</li>
    <li>Key: name, Value: test-1</li>
    <li>Key: type, Value: thing</li>
    <li>Key: moreData, Value: more</li>
    <li>Key: meta, Value: System.Dynamic.ExpandoObject</li>

    <li>Key: id, Value: 2</li>
    <li>Key: name, Value: test-2</li>
    <li>Key: type, Value: thing</li>
    <li>Key: price, Value: 100</li>
    <li>Key: meta, Value: System.Dynamic.ExpandoObject</li>
</ul>

<ul>
    <li>Key: id, Value: 1</li>
    <li>Key: name, Value: test-1</li>
    <li>Key: type, Value: thing</li>
    <li>Key: moreData, Value: more</li>
    <li>Key: meta, Value: System.Dynamic.ExpandoObject</li>

    <li>Key: id, Value: 2</li>
    <li>Key: name, Value: test-2</li>
    <li>Key: type, Value: thing</li>
    <li>Key: price, Value: 100</li>
    <li>Key: meta, Value: System.Dynamic.ExpandoObject</li>
</ul>

<ul>
    <li>Failed to find match</li>
</ul>

<ul>
    <li>Key: id, Value: 2</li>
    <li>Key: name, Value: test-2</li>
    <li>Key: type, Value: thing</li>
    <li>Key: price, Value: 100</li>
    <li>Key: meta, Value: System.Dynamic.ExpandoObject</li>
</ul>

<ul>
    <li>Key: id, Value: 2</li>
    <li>Key: name, Value: test-2</li>
    <li>Key: type, Value: thing</li>
    <li>Key: price, Value: 100</li>
    <li>Key: meta, Value: System.Dynamic.ExpandoObject</li>

    <li>Key: id, Value: 3</li>
    <li>Key: name, Value: test-3</li>
    <li>Key: type, Value: something else</li>
</ul>
```

---
## Helpers.Object.Lookup
|||
|-|-|
|**Summary**|Pull object by key from a dynamic object|
|**Returns**|Object that is found|
|**Remarks**||
|||
|**Parameters**||
|_input_|Object to pull from|
|_lookup_|Key to look for|

#### Example
**Context**
``` json
{
    "objects": {
        "thing1": {
            "id": 1,
            "name": "test-1"
        },
        "thing2": {
            "id": 2,
            "name": "test-2"
        },
        "thing3": {
            "id": 3,
            "name": "test-3"
        }
    }
}
```
**Usage**
``` handlebars
<strong>result:</strong>
<ul>
    {{#Helpers.Object.Lookup objects "thing1"}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Lookup}}
</ul>
<ul>
    {{#Helpers.Object.Lookup objects "thing2"}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Lookup}}
</ul>
<ul>
    {{#Helpers.Object.Lookup objects "something"}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Object.Lookup}}
</ul>
```
**Returns**
``` html
<strong>result:</strong>
<ul>
    <li>Key: id, Value: 1</li>
    <li>Key: name, Value: test-1</li>
</ul>
<ul>
    <li>Key: id, Value: 2</li>
    <li>Key: name, Value: test-2</li>
</ul>
<ul>
    <li>Failed to find match</li>
</ul>
```

---
## Helpers.Path.GetKeyValuePairMatches
|||
|-|-|
|**Summary**|Given path, determine if key and value exist|
|**Returns**|Returns matching records|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_keyValuePairs_|List of key value pairs|
|_delimiter_|Delimiter to parse path with, defaults to /|
|_offset_|Offset to start key/value pair loading, defaults to 0|

#### Example
**Context**
``` json
{
    "value": "/search/inventory/type/Snowmobile/brand/Arctic%20Cat",
    "match1": {
        "id": 1,
        "key": "type",
        "value": "Snowmobile"
    },
    "match2": {
        "name": "test",
        "key": "type",
        "values": [
            "ATV",
            "Snowmobile",
            "Bike"
        ]
    },
    "match3": [
        {
            "key": "type",
            "value": "Snowmobile"
        },
        {
            "specialThing": "thing",
            "key": "brand",
            "values": [
                "Yamaha",
                "Honda"
            ]
        }
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
<ul>
    {{#Helpers.Path.GetKeyValuePairMatches value match1}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Path.GetKeyValuePairMatches}}
</ul>

<ul>
    {{#Helpers.Path.GetKeyValuePairMatches value match1 "/" 1}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Path.GetKeyValuePairMatches}}
</ul>

<ul>
    {{#Helpers.Path.GetKeyValuePairMatches value match1 "_"}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Path.GetKeyValuePairMatches}}
</ul>

<ul>
    {{#Helpers.Path.GetKeyValuePairMatches value match1 "/" 2}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Path.GetKeyValuePairMatches}}
</ul>

<ul>
    {{#Helpers.Path.GetKeyValuePairMatches value match2}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Path.GetKeyValuePairMatches}}
</ul>

<ul>
    {{#Helpers.Path.GetKeyValuePairMatches value match3}}
        {{#each this}}
            {{#each this}}
                <li>Key: {{@key}}, Value: {{this}}</li>
            {{/each}}
        {{/each}}
    {{else}}
        <li>Failed to find match</li>
    {{/Helpers.Path.GetKeyValuePairMatches}}
</ul>
```
**Returns**
``` html
<strong>result:</strong>
<ul>
    <li>Key: id, Value: 1</li>
    <li>Key: key, Value: type</li>
    <li>Key: value, Value: Snowmobile</li>
</ul>

<ul>
    <li>Failed to find match</li>
</ul>

<ul>
    <li>Failed to find match</li>
</ul>

<ul>
    <li>Key: id, Value: 1</li>
    <li>Key: key, Value: type</li>
    <li>Key: value, Value: Snowmobile</li>
</ul>

<ul>
    <li>Key: name, Value: test</li>
    <li>Key: key, Value: type</li>
    <li>Key: values, Value: System.Collections.Generic.List`1[System.Object]</li>
</ul>

<ul>
    <li>Key: key, Value: type</li>
    <li>Key: value, Value: Snowmobile</li>
</ul>
```

---
## Helpers.Path.HasExtension
|||
|-|-|
|**Summary**|Given path, get whether or not it contains a file extension|
|**Returns**|Whether or not it contains a file extension|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_extension_|Extension to look for|

#### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/docs/helpers.md"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Path.HasExtension value "md"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasExtension}}

{{#Helpers.Path.HasExtension value "txt"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasExtension}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>
```

---
## Helpers.Path.HasKeyValuePairMatch
|||
|-|-|
|**Summary**|Given path, determine if key and value exist|
|**Returns**|Whether or not key and value exist|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_key_|Key to look for|
|_value_|Value to look for|
|_delimiter_|Delimiter to parse path with, defaults to /|
|_offset_|Offset to start key/value pair loading, defaults to 0|

#### Example
**Context**
``` json
{
    "value": "/search/inventory/type/Snowmobile/brand/Arctic%20Cat"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Path.HasKeyValuePairMatch value "type" "Snowmobile"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasKeyValuePairMatch}}

{{#Helpers.Path.HasKeyValuePairMatch value "type" "Snowmobile" "/" 1}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasKeyValuePairMatch}}

{{#Helpers.Path.HasKeyValuePairMatch value "type" "Snowmobile" "_"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasKeyValuePairMatch}}

{{#Helpers.Path.HasKeyValuePairMatch value "brand" "Arctic%20Cat" "/" 2}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasKeyValuePairMatch}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>False</strong>

<strong>True</strong>
```

---
## Helpers.Path.HasSegment
|||
|-|-|
|**Summary**|Given path, determine if segment exists|
|**Returns**|Whether or not segment exists|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|
|_segment_|Segment to look for|
|_delimiter_|Delimiter to parse path with, defaults to /|

#### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/docs/helpers.md"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Path.HasSegment value "HandlebarDocs"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasSegment}}

{{#Helpers.Path.HasSegment value "HandlebarDocs" "_"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasSegment}}

{{#Helpers.Path.HasSegment value "test"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Path.HasSegment}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>False</strong>
```

---
## Helpers.Path.ParseUnitSlug
|||
|-|-|
|**Summary**|Given a bigInteger url slug, parse out the values|
|**Returns**|Object representing parsed values|
|**Remarks**||
|||
|**Parameters**||
|_path_|Path to pull info from|

#### Example
**Context**
``` json
{
    "value1": "https://www.rjsportandcycle.com/new-models/arctic-cat-3",
    "value2": "https://www.rjsportandcycle.com/new-models/arctic-cat-snowmobile-trail-1573876204375371459592195"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
<ul>
    {{#Helpers.Path.ParseUnitSlug value1}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failure to parse</li>
    {{/Helpers.Path.ParseUnitSlug}}
</ul>

<ul>
    {{#Helpers.Path.ParseUnitSlug value2}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failure to parse</li>
    {{/Helpers.Path.ParseUnitSlug}}
</ul>

<ul>
    {{#Helpers.Path.ParseUnitSlug "https://www.rjsportandcycle.com/new-models/yamaha-scooters-6498285518888"}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failure to parse</li>
    {{/Helpers.Path.ParseUnitSlug}}
</ul>

<ul>
    {{#Helpers.Path.ParseUnitSlug "https://www.google.com/"}}
        {{#each this}}
            <li>Key: {{@key}}, Value: {{this}}</li>
        {{/each}}
    {{else}}
        <li>Failure to parse</li>
    {{/Helpers.Path.ParseUnitSlug}}
</ul>
```
**Returns**
``` html
<strong>result:</strong>
<ul>
    <li>Key: Id, Value: 0</li>
    <li>Key: IsUnitInventory, Value: False</li>
    <li>Key: ProductOwnerId, Value: 3</li>
    <li>Key: TypeId, Value: 0</li>
    <li>Key: ClassId, Value: 0</li>
</ul>

<ul>
    <li>Key: Id, Value: 0</li>
    <li>Key: IsUnitInventory, Value: False</li>
    <li>Key: ProductOwnerId, Value: 3</li>
    <li>Key: TypeId, Value: 1507</li>
    <li>Key: ClassId, Value: 85320</li>
</ul>

<ul>
    <li>Key: Id, Value: 0</li>
    <li>Key: IsUnitInventory, Value: False</li>
    <li>Key: ProductOwnerId, Value: 40</li>
    <li>Key: TypeId, Value: 1513</li>
    <li>Key: ClassId, Value: 0</li>
</ul>

<ul>
    <li>Failure to parse</li>
</ul>
```
---
## Helpers.Regex.IsMatch
|||
|-|-|
|**Summary**|Determine if regex pattern matches on string|
|**Returns**|Whether or not a match was found|
|**Remarks**||
|||
|**Parameters**||
|_str_|Input|
|_pattern_|Regex pattern|

#### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/docs/helpers.md"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Regex.IsMatch value "(blob|master|test)"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Regex.IsMatch}}

{{#Helpers.Regex.IsMatch value "/d+/"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Regex.IsMatch}}

{{#Helpers.Regex.IsMatch value "ari[^n]"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Regex.IsMatch}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>False</strong>
```

---
## Helpers.String.Contains
|||
|-|-|
|**Summary**|Determine if the string contains a substring|
|**Returns**|Whether or not string contains substring|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_match_|String to match|
|_ignoreCase_|Whether or not to ignore case, defaults to false|

#### Example
**Context**
``` json
{
    "value": "something wicked this way comes."
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.String.Contains value "wicked"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.Contains}}

{{#Helpers.String.Contains value "Wicked"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.Contains}}

{{#Helpers.String.Contains value "Wicked" true}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.Contains}}

{{#Helpers.String.Contains "test this thing out" "is"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.Contains}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>True</strong>

<strong>False</strong>
```

---
## Helpers.String.EndsWith
|||
|-|-|
|**Summary**|Determine if the string ends with a substring|
|**Returns**|Whether or not the string ends with substring|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_suffix_|String to match|
|_ignoreCase_|Whether or not to ignore case, defaults to false|

#### Example
**Context**
``` json
{
    "value": "something wicked this way comes"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.String.EndsWith value "comes"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.EndsWith}}

{{#Helpers.String.EndsWith value "test"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.EndsWith}}

{{#Helpers.String.EndsWith value "Comes" true}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.EndsWith}}

{{#Helpers.String.EndsWith "test this thing out" "out"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.EndsWith}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>True</strong>

<strong>True</strong>
```

---
## Helpers.String.IsString
|||
|-|-|
|**Summary**|Determine if the object passed in is a string|
|**Returns**|Whether or not object is a string|
|**Remarks**||
|||
|**Parameters**||
|_value_|Input|

#### Example
**Context**
``` json
{
    "value": "something wicked this way comes",
    "arr": [
        0,
        2,
        4
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.String.IsString this}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.IsString}}

{{#Helpers.String.IsString value}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.IsString}}

{{#Helpers.String.IsString arr}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.IsString}}

{{#Helpers.String.IsString arr[1]}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.IsString}}

{{#Helpers.String.IsString "test this"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.IsString}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>False</strong>

<strong>True</strong>

<strong>False</strong>

<strong>False</strong>

<strong>True</strong>
```

---
## Helpers.String.Split
|||
|-|-|
|**Summary**|Split a string on a supplied delimiter|
|**Returns**|Array of strings|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_ch_|Delimiter|

#### Example
**Context**
``` json
{
    "value": "something wicked this way comes"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
<ul>
   {{#Helpers.String.Split value " "}}
       {{#each this}}
           <li>{{this}}</li>
       {{/each}}
   {{else}}
       <li>NOTHING FOUND</li>
   {{/Helpers.String.Split}}
</ul>
```
**Returns**
``` html
<strong>result:</strong>
<ul>
    <li>something</li>
    <li>wicked</li>
    <li>this</li>
    <li>way</li>
    <li>comes</li>
</ul>
```

---
## Helpers.String.StartsWith
|||
|-|-|
|**Summary**|Determine if the string starts with a substring|
|**Returns**|Whether or not the string starts with substring|
|**Remarks**||
|||
|**Parameters**||
|_str_|Base string|
|_prefix_|String to match|
|_ignoreCase_|Whether or not to ignore case, defaults to false|

#### Example
**Context**
``` json
{
    "value": "something wicked this way comes"
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.String.StartsWith value "something"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.StartsWith}}

{{#Helpers.String.StartsWith value "Something"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.StartsWith}}

{{#Helpers.String.StartsWith value "Something" true}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.StartsWith}}

{{#Helpers.String.StartsWith "test this thing out" "out"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.String.StartsWith}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>

<strong>True</strong>

<strong>False</strong>
```