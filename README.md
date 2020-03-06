## Introduction
Our templates run through a [Handlebar.Net](https://github.com/rexm/Handlebars.Net) templating engine which is based on [Handlebarsjs](http://handlebarsjs.com).

Handlebars is built upon the [mustache expression engine](http://mustache.github.io/mustache.5.html). The operating principle of this expression engine is that you can inject model data into any arbitrary string by wrapping the object in "mustaches" ```{{}}```.

## [Expressions](expressions.md)
* [Basic Usage](expressions.md#basic-usage)
* [Helpers](expressions.md#helpers)
* [Sub Expressions](expressions.md#sub-expressions)
* [Whitespace](expressions.md#whitespace)
* [Escaping](expressions.md#escaping)
* [Common Gotchas](expressions.md#gotchas)

## [Built-in Variables](dataVariables.md)
* [@root](dataVariables.md#root)
* [@first](dataVariables.md#first)
* [@last](dataVariables.md#last)
* [@index](dataVariables.md#index)
* [@key](dataVariables.md#key)
* [this](dataVariables.md#this)

## [Built-in Helpers](builtinHelpers.md)
* [if](builtinHelpers.md#if)
* [unless](builtinHelpers.md#unless)
* [each](builtinHelpers.md#each)
* [with](builtinHelpers.md#with)

## [Custom Helpers](customHelpers.md)
* [Date](customHelpers/date.md)
* [HTML](customHelpers/html.md)
* [Image](customHelpers/image.md)
* [Math](customHelpers/math.md)
* [Number](customHelpers/number.md)
* [Object](customHelpers/object.md)
* [Path](customHelpers/path.md)
* [String](customHelpers/string.md)
* [Url](customHelpers/url.md)

## [Custom Block Helpers](customBlockHelpers.md)
* [Object](customBlockHelpers/object.md)
* [Path](customBlockHelpers/path.md)
* [Regex](customBlockHelpers/regex.md)
* [String](customBlockHelpers/string.md)

## [Other Functionality](otherFunctionality.md)
* [Comments](otherFunctionality.md#comments)
* [HTML Escaping](expressions.md#gotchas)
* [Inline Partials](otherFunctionality.md#inline-partials)
* [Literals](otherFunctionality.md#literals)
* [Paths](otherFunctionality.md#paths)
