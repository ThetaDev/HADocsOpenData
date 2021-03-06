# HADocsOpenData
HADocs Open Data is a metadata specification for exchanging documents. This format is implemented in HADocs (www.hadocs.com) and has been opened so that companies that has developed their own internal software also can exchange these metadata.

## About the metadata
The metadata is stored as a json string, preferably in a custom property of the PDF file containing the document(s). We have chosen to store the computer-readable data this way to avoid these data becoming "noise" for those who extensively use the PDF properties for human readable data.

When implementing parsing/reading of these metadata, be aware that not everyone implementing them will use all the fields we have defined.

We have defined that any dates may be supplied formatted as "YYYY-MM-DD" or using the full ISO 8601 standard (http://en.wikipedia.org/wiki/ISO_8601): "2012-03-19T07:22Z"/"2016-01-23T09:49:09.0829697+01:00"(default in Json.Net).

## Samples in this repository
We have added some samples of how to create/parse these data to usable datastructures, and for storing these in a PDF. 
We've used iTextSharp 4.1.6 for the sample to add these to a PDF, since this is LGPL-licensed and so is free to use. Please note that newer version of iTextSharp is released under other licenses.
We prefer using the Json.Net library for generating and parsing Json, and we have therefore currently only added a sample using this. We have selected to use the object-identity-feature from Json.Net (the "$id"-keys) but our software will be able to handle Json without these.
We do accept pull-requests, especially for code samples for handling these data with other tools/languages.

We will maintain a few sample json-files in the root folder of this repository.

## A short description of Json:
- All "objects" are enclosed in curly bracets {}
- List are enclosed in square bracets []
- All objects consist of key-value-pairs like this: "key" : "value",
- Numbers (double) will be shown without """, like this: "key": 4.2, 

Json is a much used format, so there is quite a lot of resources available online if you need to figure out how to use these metadata with any other language or tool.

For those who is most used to working with XML we've googled and found an XML to JSON using XSLT-libary, although we have not tested this, here is the link:
https://github.com/bramstein/xsltjson

### For more general information see here: 
* English: https://en.wikipedia.org/wiki/JSON
* Norwegian: https://no.wikipedia.org/wiki/JSON
