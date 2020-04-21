### SystemReserved Class - UiPath REFrameworks ###

*C# class built to be used within UiPath REFramework.*

The idea of *SystemReserved* was introduced in the [Enhanced-REFramework](https://github.com/mihhdu/Enhanced-REFramework) by [@mihhdu](https://github.com/mihhdu), where he defined a dictionary of parameters which group variables required for the framework to work correctly, like TransactionNumber, RetryNumber, etc.

This project takes the dictionary one step further by creating a custom class (SystemReserved) with the following key features and advantages:
  * It simplifies it's useage, as it would not requiere a string key which could introduce errors and also doesn't require the use of CInt to get integer values. 
  * *FrameworkFolders* class which allows developers to access the most typicall folders used in the REF without using the path to those directories, which allows to point the folders to other directories without the need to change every place where the folders are used. 
  * A dictionary that allows developers to have custom parametrs defined at runtime without the need to use another arugument and without messing with the Config dictionary.
  * It has two UiPath activities for those who want have a visual instatiation of a SystemReserved and/or a FrameworkFolders instead of just using a *new* sentence in an assign or the variables/arguments panel.
  * It has seven UiPath activities that handle the flow handling that needs to be done in the REF:
    * *IncrementTransactionNumber*, 
    * *IncrementRetryNumber*, 
    * *IncrementInitRetryNumber*,
    * *IncrementContinuousRetryNumber*,
    * *ResetRetryNumber*,
    * *ResetInitRetryNumber*, 
    * *ResetContinuousRetryNumber*


This list has the name, type and default value of each parameter present in the SystemReserved class: 
  * TransactionNumber - Int32 - Default value: 1 
  * RetryNumber - Int32 - Default value: 0 
  * InitRetryNumber - Int32 - Default value: 0 
  * ContinuousRetryNumber - Int32 - Default value: 0 
  * RobotFail - String - Default value: "" 
  * isQueueItem - boolean - Default value: False
  * Folders - FrameworkFolders - *NEW*
    * Input - String - Default value: "Data\Input"
    * Output - String - Default value: "Data\Output"
    * Temp - String - Default value: "Data\Temp"
    * Reports - String - Default value: "Data\Reports"
    * ExScreenshots - String - Default value: "Exceptions_Screenshots"
  * CustomParameters - Dictionary<String, Object> - *NEW*