# Custom Image Helpers
These helpers provide some ability to manage existing image urls.

* [Helpers.Image.BuildImageUrl](#helpersimagebuildimageurl)
* [Helpers.Image.GetBaseImageUrl](#helpersimagegetbaseimageurl)

---
## Helpers.Image.BuildImageUrl
|||
|-|-|
|**Summary**|Constructs a new image url with supplied parameter values|
|**Returns**|A new image url|
|**Remarks**|If first argument is not an image url, it will return an empty string|
|||
|**Parameters**||
|_input_|Image url to manipulate|
|||

### Example
**Context**
``` json
{
    "url": "//cdnmedia.endeavorsuite.com/images/ThumbGenerator/Thumb.aspx?img=%2f%2fcdnmedia.endeavorsuite.com%2fimages%2forganizations%2f2c3b7a35-5cb3-49f2-a511-9764f98f9fce%2finventory%2f2538342%2fDSC02149.JPG&mw=100&mh=100"
}
```
**Usage**
``` handlebars
<img src="{{Helpers.Image.BuildImageUrl url width=400 height=400 c=1}}" />
```
**Returns**
``` html
<img src="//cdnmedia.endeavorsuite.com/images/ThumbGenerator/Thumb.aspx?img=%2F%2Fcdnmedia.endeavorsuite.com%2Fimages%2Forganizations%2F2c3b7a35-5cb3-49f2-a511-9764f98f9fce%2Finventory%2F2538342%2FDSC02149.JPG&c=1&h=400&w=400" />
```

---
## Helpers.Image.GetBaseImageUrl
|||
|-|-|
|**Summary**|Attempt to extract the base url from an existing image path.  For example, you can use this to pull the original url out of a thumbGenerator path|
|**Returns**|The base image url|
|**Remarks**|If first argument is not an image url, it will return an empty string|
|||
|**Parameters**||
|_input_|Image url to extract the base url from|
|||

### Example
**Context**
``` json
{
    "url": "//cdnmedia.endeavorsuite.com/images/ThumbGenerator/Thumb.aspx?img=%2f%2fcdnmedia.endeavorsuite.com%2fimages%2forganizations%2f2c3b7a35-5cb3-49f2-a511-9764f98f9fce%2finventory%2f2538342%2fDSC02149.JPG&mw=100&mh=100"
}
```
**Usage**
``` handlebars
<img src="{{Helpers.Image.BuildImageUrl url}}" />
```
**Returns**
``` html
<img src="//cdnmedia.endeavorsuite.com/images/organizations/2c3b7a35-5cb3-49f2-a511-9764f98f9fce/inventory/2538342/DSC02149.JPG" />
```
