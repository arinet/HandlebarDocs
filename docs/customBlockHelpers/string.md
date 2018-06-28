# Custom String Block Helpers
These block helpers provide the ability to query and manage strings.

* [Helpers.String.Contains](#helpersstringcontains)
* [Helpers.String.EndsWith](#helpersstringendswith)
* [Helpers.String.IsString](#helpersstringisstring)
* [Helpers.String.Split](#helpersstringsplit)
* [Helpers.String.StartsWith](#helpersstringstartswith)

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

### Example
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

### Example
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

### Example
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

### Example
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

### Example
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