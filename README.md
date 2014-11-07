clipio
======

Very simple command line clipboard io for Windows.

##Usage

```
clipio read
```

to print the current clipboard contents as text to stdout.

```
<some command printing things> | clipio write
```

to read all of stdin and write it to the clipboard.
