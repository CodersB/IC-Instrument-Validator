# IC-Instrument-Validator
This is a sample project that creates instruments and tests the IC pins.

### Project structure
This solutions contains two projects,
1. Console App project named IC Validator.
2. Class library named InstrumentsFactory.

#### Pre-requisites
The solution requires the pre-requsites below to open and run the solution.
1. Windows 10
2. Visual Studio 2019
3. .Net 5.0 (5.0.7)

### Execute the project
To run the project, press F5 or click Debug -> Run. This will open a console window where you can create and test the IC pins

### Console app test instructions
The console app, it asks the user with the following inputs for it to run the validations against a pin and instrument.
1. Choose the type of instrument. Type 1 for Voltage or 2 for Current and hit the return key
2. Choose the model. Type 1 for low or 2 for high voltage / current instrument model.
3. Enter the pin#. Type a number between 1 and 14 and hit the return key.
4. Enter the volt value. Type any number and hit return key.
5. The validation will run for the given instrument model, pin and volt details. 
  5.1 The validation will either succeed or fail and the result is shown in the console window.


<img width="661" alt="Console app instructions" src="https://user-images.githubusercontent.com/17455804/122854015-bac07c80-d330-11eb-8954-a907b994bd53.png">

Thank you for reading the instructions. Please feel free to download the app to test and raise issues in the github repo for any errors.
Good day!


