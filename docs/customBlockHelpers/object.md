# Custom Object Block Helpers
These block helpers allow for querying, filtering, and comparing objects.

* [Helpers.Object.Compare](#helpersobjectcompare)
* [Helpers.Object.Filter](#helpersobjectfilter)
* [Helpers.Object.Lookup](#helpersobjectlookup)

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

### Example
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

### Example
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
|**Summary**|Pull object by key or index from a dynamic object or array|
|**Returns**|Object or array that is found|
|**Remarks**||
|||
|**Parameters**||
|_input_|Object/array to pull from|
|_lookup_|Key/index to look for|

### Example
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