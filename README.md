## Introduction
Our templates run through a [Handlebar.Net](https://github.com/rexm/Handlebars.Net) templating engine which is based on [Handlebarsjs](http://handlebarsjs.com).

Handlebars is built upon the [mustache expression engine](http://mustache.github.io/mustache.5.html). The operating principle of the expression engine is that you can inject model data into any arbitrary string by wrapping the object in "mustaches" ```{{}}```.

## [Expressions](docs/expressions.md)
* [Basic Usage](docs/expressions.md#basic-usage)
* [Helpers](docs/expressions.md#helpers)
* [Sub Expressions](docs/expressions.md#sub-expressions)
* [Whitespace](docs/expressions.md#whitespace)
* [Escaping](docs/expressions.md#escaping)
* [Common Gotchas](docs/expressions.md#gotchas)

## [Built-in Variables](docs/dataVariables.md)
* [@root](docs/dataVariables.md#root)
* [@first](docs/dataVariables.md#first)
* [@last](docs/dataVariables.md#last)
* [@index](docs/dataVariables.md#index)
* [@key](docs/dataVariables.md#key)
* [this](docs/dataVariables.md#this)

## [Built-in Helpers](docs/builtinHelpers.md)
* [if](docs/builtinHelpers.md#if)
* [unless](docs/builtinHelpers.md#if)
* [each](docs/builtinHelpers.md#if)
* [with](docs/builtinHelpers.md#if)

## [Custom Helpers](docs/customHelpers.md)
* [HTML](docs/customHelpers/html.md)
* [Math](docs/customHelpers/math.md)
* [Number](docs/customHelpers/number.md)
* [Object](docs/customHelpers/object.md)
* [Path](docs/customHelpers/path.md)
* [String](docs/customHelpers/string.md)
* [Url](docs/customHelpers/url.md)

## [Custom Block Helpers](docs/customBlockHelpers.md)
* [Object](docs/customBlockHelpers/object.md)
* [Path](docs/customBlockHelpers/path.md)
* [Regex](docs/customBlockHelpers/regex.md)
* [String](docs/customBlockHelpers/string.md)

## [Other Functionality](docs/otherFunctionality.md)
* [Literals](docs/otherFunctionality.md#literals)
* [Comments](docs/otherFunctionality.md#comments)
* [Paths](docs/otherFunctionality.md#paths)
* [HTML Escaping](docs/expressions.md#gotchas)