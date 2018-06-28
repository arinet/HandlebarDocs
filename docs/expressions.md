# Expressions
Contents of this document were more or less copied from here [http://handlebarsjs.com/expressions.html](http://handlebarsjs.com/expressions.html).  The resulting document is tailored to our implmentation.

* [Basic Usage](#basic-usage)
* [Helpers](#helpers)
* [Sub Expressions](#sub-expressions)
* [Whitespace](#whitespace)
* [Escaping](#escaping)
* [Gotchas](#gotchas)
---

## Basic Usage
You can reference objects in multiple ways.

#### Directly
```handlebars
<h1>{{title}}</h1>
```
This expression means "look up the title property in the current context".

#### Via dot notation
```handlebars
<h1>{{object.title}}</h1>
```
This expression means "look up the object property in the current context, then lookup the title property for that object".

#### Via an index
```handlebars
<h1>{{array[1]}}</h1>
```
This expression means "look up the array property in the current context, then return the object at index 1 of the result".

---
## Helpers
Helpers are simply identitifiers that have zero or more parameters which call an underlying function to perform work and return a result.

There are two types of helpers in handlebars.

### Inline Helpers
All inline helpers return values inline; when you reference one, its reference gets replaced by the resulting value.

For example: 
``` handlebars
<strong>{{Helper.String.Uppercase "some string"}}</strong>
```
would return 
``` html
<strong>SOME STRING</strong>
```

### Block Helpers
Block helpers return a new context specific to the resulting operation.  Things like if, each, with are block helpers.  They take an initial context, and based on the result of the operation either pass through the existing context or pass through a new context.

Block helpers are identified by a # preceeding the helper name and require a matching closing mustache, /, of the same name.

**Example**
``` handlebars
{{#if valueExists}}
    <strong>It exists</strong>
{{/if}}
```

see:
* [Build in block helpers](#builtinHelpers.md)
* [Custom block helpers](#customBlockHelpers.md)

---
## Sub Expressions
Handlebars has support for nesting expressions.  This allows for generating rather complex expressions. To reference the result of one helper as a parameter in another helper, instead of using `{{}}` on that inner helper, wrap it with `()`.

``` handlebars
{{outer-helper (inner-helper 'abc') 'def'}}
```

---
## Whitespace
Handlebars will output your template's whitespace explicitly.  To prevent this, you can add a `~` to either side of an expression.  When rendered, it will trim any whitespace on that side of the template's line.

**Context**
``` json
{
    "value": "test"
}
```

**Usage**
``` handlebars
<div>
    {{#if value}}
        {{value}}
    {{/if}}
</div>
```

**Result** showing exploding whitespace
``` html
<div>
                test
</div>
```

**Fix** using `~`
``` handlebars
<div>
    {{~#if value}}
        {{~value}}
    {{~/if}}
</div>
```

**Result** of using `~`
``` html
<div>test</div>
```

---
## Escaping
Currently our implementation does not have support for escaping `{{}}` brackets.  If you need to escape them, you'll need to add a property to the context and reference that.  For example:

**Context**
``` json
{
    "escape_l": "{{",
    "escape_r": "}}"
}
```

**Usage**
``` handlebars
<div>
    {{escape_l}}escaped{{escape_r}}
</div>
```

**Result** showing exploding whitespace
``` html
<div>
    {{escaped}}
</div>
```

---
## Gotchas
1. Expressions are html escaped by default. For example, 

    **Context**
    ``` json
    {
        "value": "<h1>test</h1>"
    }
    ```

    **Usage**
    ``` handlebars
    <div>
        {{value}}
    </div>
    ```

    **Result**
    ``` html
    <div>
        &lt;h1&gt;test&lt;/h1&gt;
    </div>
    ```

    To get this to render as expected, you'll need to use triple slashes ```{{{value}}}```