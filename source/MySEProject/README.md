# KNN Classifier

## Implementation

The KNN (K-Nearest-Neighbor) Classifier is designed and integrated with the Neocortex API. It takes in a sequence of
values and preassigned labels to train the model. Once the model (a Dictionary mapping of labels to their sequences) is
trained the user can give unclassified sequence that needs to be labeled.

**For Example:**

There are three sequences A, B and C which needs to be trained(`_model` is fed with _labeled/classified_ sequences), and
this is done using the `void Learn(TIN input, Cell[] cells)` method. Then KNN implementation can predict the label for
the provided _unclassified/unlabeled_ sequence in the next stage of the pipeline using the
`List<ClassifierResult<TIN>> GetPredictedInputValues(Cell[] unclassifiedCells, short howMany)` method.

_**Sample Data**_

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

## Getting Started:

Go to the `Samples` folder which is one folder above and inside where a folder names NeoCortexApiSample is present.
From there run the `Program.cs` file to run the KNN Classifier.

```bash
dotnet run --project "../Samples/NeoCortexApiSample/NeoCortexApiSample.csproj"
```

Path to the
Project: [KnnClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/KnnClassifier.cs)

## Testing

The unit tests are written under the `UnitTestsProject` also one folder above, run the `KnnClassifierTests.cs` for the
unittests.

Path to the Unit
test: [KnnClassifierTests.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/UnitTestsProject/KnnClassifierTests.cs)

## Changed Files

Reason being function overloading in HTM Classifier worked when called into the Predicator Function. But calling a more
Generic Classifier type into the Predicator wasn't available because those function parameters weren't available in the
IClassifier, this required me to find a common ground and change the implementation without affecting the program.

1. [IClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/IClassifier.cs)
2. [Predicator.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Predictor.cs)
3. [SDRClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/SDRClassifier.cs)
4. [HtmUnionClassifier.cs](https://github.com/ayan1948/neocortexapi/blob/master/source/NeoCortexApi/Classifiers/HtmUnionClassifier.cs)
