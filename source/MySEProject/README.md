# ML22/23- 2 Investigate and Implement KNN Classifier

## Implementation

This KNN classifier takes an input as a sequence of on: 1, off: 0 which is provided to be labeled.
Which then needs to run through a model (a Dictionary mapping of labels to their sequences) to be classified, consisting of labeled sequences.
Using the K-nearest-neighbor algorithm, the Unclassified sequence needs to be given a sequence of labels from the closest resemblances to the least.

For example:
```
_models = {
    "A" : [[1, 3, 4, 7, 12, 13, 14], [2, 3, 5, 6, 7, 8, 12]],
    "B" : [[0, 4, 5, 6, 9, 10, 13], [2, 3, 4, 5, 6, 7, 8]],
    "C" : [[1, 4, 5, 6, 8, 10, 15], [1, 2, 7, 8, 13, 15, 16]]
}
```

```
unclassified = [1, 3, 4, 7, 12, 14, 15]
```

The Verdict: `List = [A, B, ...]` "A" being the closest match, "B" the next closest match and so on ...

The Output in this case is a list of ClassifierResult objects.

### Learn
This method takes in the labeled data and inserts it to a dictionary mapping of string to a list of sequences. `Dictionary<string, List<int[]>`.

### Predict
This method is responsible in predicting the unclassified/unlabeled sequence it is provided during execution from the pipeline. It then runs the KNN,
code to fetch the closest match.

## Getting Started:

Go to the `Samples` folder which is one folder above; and inside where a folder names NeoCortexApiSample is present. From there run the `Program.cs` file to run the KNN Classifier.

Path to the Project: [KnnClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/KnnClassifier.cs)

## Testing
The unit tests are written under the `UnitTestsProject` also one folder above, run the `KnnClassifierTests.cs` for the unittests.

Path to the Unit test: [KnnClassifierTests.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/UnitTestsProject/KnnClassifierTests.cs)

## Changed Files

Reason being function overloading in HTM Classifier worked when called into the Predicator Function. But calling a more Generic Classifier type into the Predicator wasn't available because those function parameters weren't available in the IClassifier, this required me to find a common ground and change the implementation without affecting the program.

1. [IClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/IClassifier.cs)
2. [Predicator.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Predictor.cs)
3. [SDRClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/SDRClassifier.cs)
4. [HtmUnionClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/HtmUnionClassifier.cs)
