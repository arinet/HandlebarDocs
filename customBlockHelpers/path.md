# Custom Path Block Helpers
These block helpers allow for querying and parsing paths.

* [Helpers.Path.GetKeyValuePairMatches](#helperspathgetkeyvaluepairmatches)
* [Helpers.Path.HasExtension](#helperspathhasextension)
* [Helpers.Path.HasKeyValuePairMatch](#helperspathhaskeyvaluepairmatch)
* [Helpers.Path.HasSegment](#helperspathhassegment)
* [Helpers.Path.ParseUnitSlug](#helperspathparseunitslug)

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

### Example
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

### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/customHelpers.md"
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

### Example
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

### Example
**Context**
``` json
{
    "value": "https://github.com/arinet/HandlebarDocs/blob/master/customHelpers.md"
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

### Example
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