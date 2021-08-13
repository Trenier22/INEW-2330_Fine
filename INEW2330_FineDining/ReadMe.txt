 * For the Email Password recovery you will need to enter your own email and email password into the from/pass fields. You will find those values in the frmForgotPassword.cs
Form and in the code it will be under btnSendCode_Click, you will enter your email address into from(line 50) and your email password into pass(line 51). You wanted me to remind
you to do this when we spoke the other day.
 
 
  * Credentials for login testing:
  Customer Username: jharris				Customer Password: 12345
 
  Employee Username: stephenkolls		Employee Password: 12345
 
  Manager Username: kathywilganowski		Manager Password: 12345
 
 
  * Credentials for Payment testing:
  First Name: Stephen
  Last Name: Kolls
  Credit Card Number: 1234123412341234
  CVV: 123
  
  
  
 * Basic Overview:
  On start you will be presented with the login form which has 3 levels of security, one for Manager, Employees, and Customers. You will then enter in the apporopriate credentials
  for which form you wish to access.
  
  Manager Form: When you enter into the Manager form you will see a DGV with all of the Employees info including their payments. You can update these row by changing a value in the 
  DGV and clicking update, you can also remove a row by highlighint the row and clicking delete. You will also see another DGV which will show all of the Orders placed on record. You 
  can the click Print Orders to print out the Orders information.
  
  Employees Form: When you wnter the Employees form you will see a DGV containing information about the currently logged in employee.
  
  Customer Form: When you enter the Customer form you will be greeted with the Restraunts main menu. From here you can choose one of four options, Menu, About US, CLose, and Order.
  When you click on MEnu you will see a DGV filled with items from the restraunts menu, you can click on the Print button to print out the menu or close to exit the menu form. The 
  About Us button will display a form containing general information about the restraunt, you can click the close button to return to the main menu. The Close button will return you
  to the Login form. The Order button will display a list of items from the menu, you must click on an item from the list and use the + or - buttons to select the quantity you wish 
  to order. Once you've selected your quantity click the Add to Cart button, this will add the selected quantity of the selected item to the cart. You can then click the View Cart 
  button to view the current items in your cart and the total cost of said items. if you wish to remove an item from the cart sleect an item from the menu and click Remove From Cart,
  this will remove a quantity of 1 from slected item and adjust the total price accordingly. If you click the Check out button you will see several textboxes, you must enter your 
  First and Last Name into the textboxes, then enter the Credit Card Number and CVV connected to your account. If you click the Pay button and the information is correct you will be 
  told that the purchase has been completed and a new record has been added to the Orders form. If you do not have an account you can click the Register button on the Payment form to 
  create a customer account. 
  
  If you click on the Forgot Password button you will see several textboxes, enter in your email and press send code, you will then receive an email with the veification code required
  for the Enter Verification Code textbox. Once you've entered in your verification code press verify, this will display a screen where you can enter in your username for either an 
  Employee or a Customer. Enter in your username and a new password and you will update that usernames password.
  
  

 
  
  
 