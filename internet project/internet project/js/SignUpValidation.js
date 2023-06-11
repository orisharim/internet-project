function validateForm() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    var confirmPassword = document.getElementById("confirmpassword").value;
    var name = document.getElementById("name").value;
    var familyName = document.getElementById("familyname").value;
    var dob = document.getElementById("dob").value;
    var city = document.getElementById("city").value;
    var email = document.getElementById("email").value;
    var phoneNumber = document.getElementById("phonenumber").value;
    var usernameRegex = /^[a-zA-Z0-9_]{3,}$/;
    if (!username.match(usernameRegex)) {
        alert("Username must be at least 3 characters long and can only contain letters, numbers, and underscores.");
        return false;
    }
    if (password.length < 4 && password.length > 10) {
        alert("Password must be more than 4 characters long and less than 10");
        return false;
    }
    if (password != confirmPassword) {
        alert("password and confirm password must match");
        return false;
    }
    if (name.trim().length === 0) {
        alert("Please enter your name.");
        return false;
    }
    if (familyName.trim().length === 0) {
        alert("Please enter your family name.");
        return false;
    }
    if (dob.trim().length === 0) {
        alert("Please enter your date of birth.");
        return false;
    }
    if (city.trim().length === 0) {
        alert("Please enter your city.");
        return false;
    }
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!email.match(emailRegex)) {
        alert("Please enter a valid email address.");
        return false;
    }
    if (!phoneNumber.match(phoneNumberRegex)) {
        alert("please enter a valid number");
    }
    if (phoneNumber.trim().length === 0) {
        alert("Please enter a phone number.");
        return false;
    }
    return true;
}
