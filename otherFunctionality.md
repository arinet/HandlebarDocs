# Other Functionality
Contents of this document were more or less copied from here [http://handlebarsjs.com/](http://handlebarsjs.com/).  The resulting document is tailored to our implmentation.

* [Literals](#literals)
* [Comments](#comments)
* [Paths](#paths)
* [HTML Escaping](expressions.md#gotchas)

---
## Literals
Often it's necessary to pass data directly into a helper. Supported literals include numbers, strings, true, false, null and undefined.

**Usage**
``` handlebars
{{#Helpers.String.Contains "My test string" "test" true}}
    True
{{else}}
    False
{{/Helpers.String.Contains}}
```

**Returns**
```
True
```

---
## Comments
When generating large templates, it can be helpful to add comments to both break up the template into visible sections and to provide insight for people looking at the template in the future.  In handlebars, you can do this by placing your comment inside of `{{!-- --}}`

**Usage**
``` handlebars
<div>
    {{!-- Return whether or not "test" is found in "My test string" --}}
    {{#Helpers.String.Contains "My test string" "test" true}}
        <span>True</span>
    {{else}}
        <span>False</span>
    {{/Helpers.String.Contains}}
</div>
```

**Returns**
``` html
<div>
    <span>True</span>
</div>
```

---
## Paths
When using block helpers, you will find that your context will often change; when this happens, if you need to access parent contexts, you'll need to use pathing `../`

**Context**
``` json
{
    "value": "test",
    "someObject": {
        "id": 1,
        "name": "object"
    }
}
```

**Usage**
``` handlebars
<div>
    <span>{{value}}</span>
    {{#with someObject}}
        <span>{{id}}</span>
        <span>{{../value}}</span>
    {{/with}}
</div>
```

**Returns**
``` html
<div>
    <span>test</span>
    <span>1</span>
    <span>test</span>
</div>
```

The exact value that `../` will resolve to varies based on the helper that is called. Using `../` is only necessary when context changes, so children of helpers such as `each` would require the use of `../` while children of helpers such as `if` do not.

**Example**
``` handlebars
<span>Current Context: {{value}}</span>
{{#each someObject}}
    <span>Parent: {{../value}}</span>
    <span>Current context: {{@key}}</span>
    {{#if name}}
        <span>Parent: {{../value}}</span>
    {{/if}}
{{/each}}
```

**Returns**
``` html
<span>Current Context: test</span>
<span>Parent: test</span>
<span>Current context: id</span>
<span>Parent: test</span>
<span>Current context: name</span>
```

Handlebars also allows for name conflict resolution between helpers and data fields via a [`this`](dataVariables.md#this) reference:

``` handlebars
<p>{{./name}} or {{this/name}} or {{this.name}}</p>
```

Any of the above would cause the name field on the current context to be used rather than a helper of the same name.