# Punch Clock

Punch Clock is a user-friendly punch clock application designed to streamline the recording of employees' clock in/out times and facilitate data storage in a database for future reference. This application aims to simplify time tracking and enhance efficiency in workforce management.

## How It Works

1. <span style="font-size: 18px;">Click the "Clock in/out" button to reveal the "swipe in" and "swipe out" options.</span>

2. <span style="font-size: 18px;">Choose either "swipe in" or "swipe out" to proceed to the corresponding window.</span>

3. <span style="font-size: 18px;">Use your ID card with the card reader and observe the pop-up messages.</span>

## Different Scenarios and Messages

1. **Missed Clock In, Swiped Out**: If an employee swipes out without swiping in earlier on the same day, a message will inform them that they missed their clock in. The clock-in and clock-out times for the day will be recorded as the same. An automatic email notification will be sent to the manager.

2. **Missed Clock Out, Swiped In**: If an employee swipes in on a new day without having swiped out the previous day, the system will inform them about the missed clock out. The clock-out time for the missed day will be set as the same time as their clock-in time. This notice will only appear once. An automatic email notification will be sent to the manager.

3. **Multiple Swipe Ins**: If an employee attempts to swipe in multiple times on the same day, a message will notify them that they have already swiped in for the day.

4. **Successful Swipe In/Out**: When an employee successfully swipes in or out, a message will confirm that their time record has been updated in the database.

5. **Troubleshooting**:
   - Check the language setting at the bottom right corner; it should be set to "ENG US," not "ENG CMS."
   - If the application malfunctions, ensure all instances of the punch clock program are closed before opening a new one.
   - Before swiping, listen for three beeps; a rapid succession of beeps indicates the previous user swiped too quickly. Restart the app for proper functionality.

## Migration to Another Desktop

1. Download and install Visual Studio 2019 to run the project.

2. Ensure that Visual Studio 2019 on the new desktop has the same workloads and individual components as the one on the old desktop.

3. Download the ID-Tech mag-card reader driver and the configuration app.

4. Follow these steps to insert the "OPOS MSR Control" into the Toolbox:

   - [Step 1: (Details not provided)]
   - [Step 2: Insert the "OPOS MSR Control" into the Toolbox]

## Disclaimer

This README provides a general overview of the Punch Clock application and its usage scenarios. For detailed installation instructions and troubleshooting, please refer to the project documentation.
