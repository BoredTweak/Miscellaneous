# Toxicity Data Prep

This was an effort to use the [toxicity_annotated_comments](../../@shared/wiki-toxicity-data/toxicity_annotated_comments.tsv) data to train the ML.NET model. [toxicity_annotations](../../@shared/wiki-toxicity-data/toxicity_annotations.tsv) has labels keyed to an ID in the comments file. As such this parser was an effort to brute force merging the two data sets. 

I then realized that I could just use a pre-parsed version of the file from [https://github.com/dotnet/machinelearning-samples](https://github.com/dotnet/machinelearning-samples).

To use this toxicity-parser anyways, install Python 3.9+ and run `py toxicity-parser.py` from a terminal instance in this directory.
