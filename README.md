# NSS CSharp Capstone Project


## Name of Project: “Health Care Assist Provider”


## Brief Proposal:
A healthcare-related humanitarian project for three groups of people: 
* who need healthcare treatment (patients), 
* who provide healthcare-related services (doctors), 
* who can provide appropriate help to get healthcare treatment (sponsors).
The application creates a connection between people who cannot afford health insurance and healthcare providers like doctors and physicians. In addition, sponsors can donate money to help with external costs associated with treatments.


## Stack: MVC 


## App Summary

## MVP Definition: 
* User-specific CRUD for tree type of users: Patient, Doctor, and Sponsor
* User-specific lists of the Patients, Doctors, and Sponsors
* Ability for a Patient to create Diagnosis request
* Ability to schedule an Appointment when appropriate date-time and aids funds are available
* Ability for a Patient to rate an Appointment and comment it
* Ability for a Doctor to provide information on Date, Time and Price of Appointments
* Ability for a Doctor to schedule an Appointment for a particular Patient with no charge for it
* Ability for a Sponsor to indicate the sum of money she can give for aid
* Ability for a Sponsor to indicate a Patient whom she provides assist.


## User Stories

1. User should be able to create an account
When the user clicks on the Register link
Then the following input fields should be presented:
- List of types of the User account to choose from (drop-down select menu?)
- the e-mail address
- the password and password confirmation

2. User should be asked to provide required account information
When the user is logged in for the first time
Then a form should be displayed in which the following information can be entered:
for all type of users:
- First name and Last name
- contact e-mail address (can be different from the account e-mail)
- mailing home or office address
for Patient account type:
- Date of Birth
for Doctor account type:
- doctors Specialization
- valid license number

3. Given a Patient wants to view a list of available Appointments for specific Speciality
When the Patient clicks on the Doctors item in the navigation bar
Then all Doctors of specific Speciality with available Appointments should be listed with the following information:
- First name and last name
- Specialty
- Doctors rating
- Date and Time, available to schedule appointment

4. Given a Patient wants to view detailed information on a particular Doctor
When the Patient clicks on the Doctors name from the list, presented in Doctors section
Then the Detailed information about Doctors should be presented.

5. Given a Patient wants to check a sum of available aids provided from Sponsor
When the Patient clicks on the Sponsor item in the navigation bar
Then the list of all Sponsors with available aids money at the moment should be presented with the information:
- First name and last name
- Sum of money for aids available at the moment

4. Given a Patient wants to schedule an appointment
When the Patient clicks on the Appointment item in the navigation bar
Then the following information should be presented:
- the Patients own First name and last name
- Specialty needed based on Diagnosis provided
- List of Doctors to choose from (drop-down select menu)
- List of available Date and Time to schedule appointment (drop-down select menu)
- List of Sponsors, who provide enough money to pay for appointment (drop-down select menu)
And then clicks on the Submit button
Then the DiagnosesAppointment item should be created

7. The Doctor should be able to provide an appointment information
Given a Doctor wants to provide an Appointment related information
When the Doctor clicks on the Create Appointment button
Then a form should be displayed in which the following information can be entered:
- new Appointment date and time
- a required Appointment charge sum

8. The Doctor should be able to schedule a free of charge appointment
Given a Doctor wants to schedule a free of charge appointment for a particular Patient
When the Doctor clicks on Name of Patient in the presented list
Then the following information should be presented:
- the Patients own First name and last name
- Specialty needed based on Diagnosis provided
- List of available Date and Time to schedule an appointment (drop-down select menu)
- And then clicks on the Submit button
Then the DiagnosesAppointment item should be created

9. The Sponsor should be able to update the sum of donation
Given the Sponsor wants to update the sum of donation
When the Sponsor clicks on her name in the list
Then the detailed information should be presented with an input field for the sum of donation.

10. The Sponsor should be able to schedule an appointment
Given a Sponsor wants to schedule an appointment for a particular Patient
When the Sponsor clicks on Name of Patient in the presented list
Then the following information should be presented:
- the Patients own First name and last name
- Specialty needed based on Diagnosis provided
- List of Doctors to choose from (drop-down select menu)
- List of available Date and Time to schedule an appointment (drop-down select menu)
- And then clicks on the Submit button
Then the DiagnosesAppointment item should be created

11. Given a Patient wants to add a comment for appointment
When the Patient clicks on the Appointment item in the navigation bar
Then the list of Appointments should be presented with the Add comment button.


## ERD:
![Initial ERD](/CSharpCapstoneERD.png)
