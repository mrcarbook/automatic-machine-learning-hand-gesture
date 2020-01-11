
# Hand Gesture Project

The project use ML.Net and Hand Gesture Recognition Database from this [kaggle repository](https://www.kaggle.com/gti-upm/leapgestrecog)  based on Leap Motion Sensor. The Database is a collection of near-infra-red images of ten distinct hand gestures. In this notebook we use end-to-end deep learning to build a classifier for these images.

![alt Hand Gesture](https://github.com/mrcarbook/handgesture/blob/master/HandGestureML.WebApp/wwwroot/CameraPhotos/dataset-cover.png)

We use [ML.Net Model Builder](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet/model-builder) to build Machine Learning Model to recognize Gesture Hand.

Below some picture of Model Builder wizard, with only 3 steps we build an image classification model but before to start, please download [the Hand Gesture Database](https://www.kaggle.com/benenharrington/hand-gesture-recognition-database-with-cnn/data) and unzip on your file system, you will see these folders:

![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/data.PNG)

2) Create new .Net core project and start the wizard of Model Builder and select the data folder 
![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/datapreview.PNG)

3) Start the traing, the dataset is about 20.000 images.
![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/train.PNG)

4) Finaly evaluate and test it
![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/evalute.PNG)

Finaly I created a web app project to take snapshot with webcam and use the machine learning model to recognize the gesture. Below the example where recognize an OK- Hand Gesture.

![alt Data](https://github.com/mrcarbook/handgesture/blob/master/Model%20Training/prediction.PNG)

Next step, I'm working on the machine learning model in order to improve the prediction of gesture and use it in realtime application with a video streaming. 

Keep you update!
