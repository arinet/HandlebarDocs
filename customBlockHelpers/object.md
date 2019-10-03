# Custom Object Block Helpers
These block helpers allow for querying, filtering, and comparing objects.

* [Helpers.Object.Compare](#helpersobjectcompare)
* [Helpers.Object.Distinct](#helpersobjectdistinct)
* [Helpers.Object.Filter](#helpersobjectfilter)
* [Helpers.Object.IsFirst](#helpersobjectisfirst)
* [Helpers.Object.IsLast](#helpersobjectislast)
* [Helpers.Object.Lookup](#helpersobjectlookup)
* [Helpers.Object.Page](#helpersobjectpage)
* [Helpers.Object.Skip](#helpersobjectskip)
* [Helpers.Object.Take](#helpersobjecttake)

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
## Helpers.Object.Distinct
|||
|-|-|
|**Summary**|Return a collection of distinct elements from an array|
|**Returns**|Updated collection of distinct elements|
|**Remarks**|If object is not an array, this will drop into the else block. **Note**: this can be used with an array of maps/objects, it does not need to be an array of simple types(string, numeric, bool, etc..)|
|||
|**Parameters**||
|_array_|Array of objects to make distinct|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "two",
        "two",
        "three"
    ],
    "badInput": {
        "something": true
    }
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.Distinct array}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Distinct}}

{{#Helpers.Object.Distinct badInput}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Distinct}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>
<ul>
    <li>Value: one</li>
    <li>Value: two</li>
    <li>Value: three</li>
<ul>

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
## Helpers.Object.IsFirst
|||
|-|-|
|**Summary**|Determine whether or not the object passed in is the first element in the passed in array|
|**Returns**|Whether or not the object is the first element in the array|
|**Remarks**||
|||
|**Parameters**||
|_array_|Array of objects to inspect|
|_object_|Object to match on|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "three"
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.IsFirst array "one"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.IsFirst}}

{{#Helpers.Object.IsFirst array "two"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.IsFirst}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>

<strong>False</strong>
```

---
## Helpers.Object.IsLast
|||
|-|-|
|**Summary**|Determine whether or not the object passed in is the last element in the passed in array|
|**Returns**|Whether or not the object is the last element in the array|
|**Remarks**||
|||
|**Parameters**||
|_array_|Array of objects to inspect|
|_object_|Object to match on|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "three"
    ]
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.IsLast array "one"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.IsLast}}

{{#Helpers.Object.IsLast array "three"}}
    <strong>True</strong>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.IsLast}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>False</strong>

<strong>True</strong>
```

---
## Helpers.Object.Lookup
|||
|-|-|
|**Summary**|Pull object by key or index from a dynamic object or array|
|**Returns**|Object that is found|
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

---
## Helpers.Object.Page
|||
|-|-|
|**Summary**|Return a collection of elements from an array, skipping N elements|
|**Returns**|A single page worth of elements|
|**Remarks**|If object is not an array, if page number is not passed in, or if page number or countPerPage are <= 0, this will drop into the else block. **Note**: this can be used with an array of maps/objects, it does not need to be an array of simple types(string, numeric, bool, etc..)|
|||
|**Parameters**||
|_array_|Array of objects to evaluate|
|_pageNumber_|Page number|
|_countPerPage_|Number of elements per page, default 0|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "three",
        "four",
        "five"
    ],
    "badInput": {
        "something": true
    }
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.Page array 2 2}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Page}}

{{#Helpers.Object.Page badInput 1 3}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Page}}

{{#Helpers.Object.Page array 1 -1}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Page}}

{{#Helpers.Object.Page array 0 2}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Page}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>
<ul>
    <li>Value: three</li>
    <li>Value: four</li>
<ul>

<strong>False</strong>

<strong>False</strong>

<strong>False</strong>
```

---
## Helpers.Object.Skip
|||
|-|-|
|**Summary**|Return a collection of elements from an array, skipping N elements|
|**Returns**|Collection of elements, minus the ones that were skipped|
|**Remarks**|If object is not an array, this will drop into the else block. **Note**: this can be used with an array of maps/objects, it does not need to be an array of simple types(string, numeric, bool, etc..)|
|||
|**Parameters**||
|_array_|Array of objects to evaluate|
|_skipN_|Number of elements to skip|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "three"
    ],
    "badInput": {
        "something": true
    }
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.Skip array 2}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Skip}}

{{#Helpers.Object.Skip badInput 1}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Skip}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>
<ul>
    <li>Value: three</li>
<ul>

<strong>False</strong>
```

---
## Helpers.Object.Take
|||
|-|-|
|**Summary**|Return a collection of N elements from an array|
|**Returns**|Collection of N elements|
|**Remarks**|If object is not an array, this will drop into the else block. **Note**: this can be used with an array of maps/objects, it does not need to be an array of simple types(string, numeric, bool, etc..)|
|||
|**Parameters**||
|_array_|Array of objects to evaluate|
|_takeN_|Number of elements to return|

### Example
**Context**
``` json
{
    "array": [
        "one",
        "two",
        "three"
    ],
    "badInput": {
        "something": true
    }
}
```
**Usage**
``` handlebars
<strong>result:</strong>
{{#Helpers.Object.Take array 2}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Take}}

{{#Helpers.Object.Take badInput 1}}
    <strong>True</strong>
    <ul>
    {{#each this}}
        <li>Value: {{this}}</li>
    {{/each}}
    <ul>
{{else}}
    <strong>False</strong>
{{/Helpers.Object.Take}}
```
**Returns**
``` html
<strong>result:</strong>
<strong>True</strong>
<ul>
    <li>Value: one</li>
    <li>Value: two</li>
<ul>

<strong>False</strong>
```