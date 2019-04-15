# Other Functionality
Contents of this document were more or less copied from here [http://handlebarsjs.com/](http://handlebarsjs.com/).  The resulting document is tailored to our implmentation.

* [Comments](#comments)
* [HTML Escaping](expressions.md#gotchas)
* [Inline Partials](#inline-partials)
* [Literals](#literals)
* [Paths](#paths)

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
## Inline Partials
Occasionally it can be helpful to reuse aspects of a template. Templates may define block scoped partials via the `inline` decorator. This means that once you've declared an inline partial in your template, it can only be used in the current scope or any child scopes. 

***Note:*** You can also pass arbitrary named parameters into the partials by appending `variableName="value"` to the partial's reference call. For example: `{{> partialName variableName="value"}}`. This will append the variable `variableName` to the context that is passed to the inline partial. If an existing property in the context exists with the same name, it's value will be replaced with the `"value"` you passed in.

**Context**
``` json
{
	"items": [
		{
			"name": "Google",
			"link": "http://www.google.com",
			"flag": false
		},
		{
			"name": "Github",
			"link": "http://www.github.com",
			"flag": true
		},
		{
			"name": "Nasa",
			"link": "http://www.nasa.gov",
			"flag": false
		}
	]
}
```

**Usage**
``` handlebars
{{#*inline "link"}}
	<a href="{{link}}" class="{{class}}">{{name}}</a>
{{/inline}}

<div>
    {{#each items}}
        {{#if flag}}
            <strong>
                {{> link}}
            </strong>
        {{else}}
            {{> link}}
        {{/if}}
    {{/each}}

    {{#with items.1}}
        {{> link class="favorite"}}
    {{/with}}
</div>
```

**Returns**
``` html
<div>
	<a href="http://www.google.com" class="">Google</a>
	<strong>
		<a href="http://www.github.com" class="">Github</a>
	</strong>
	<a href="http://www.nasa.gov" class="">Nasa</a>

	<a href="http://www.github.com" class="favorite">Github</a>
</div>
```

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