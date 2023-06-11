function validatePassword(){
    var password = document.getElementById("password").value;
    
    if (password.length < 4 && password.length > 10) {
        alert("Password must be more than 4 characters long and less than 10");
        return false;
    }
    return true;
}

function validateName() {
    var name = document.getElementById("name").value;

    if (name.trim().length === 0) {
        alert("Please enter your name.");
        return false;
    }
    return true;
}

function validateFamilyName() {
    var familyName = document.getElementById("familyName").value;
    if (familyName.trim().length === 0) {
        alert("Please enter your family name.");
        return false;
    }
    return true;
}

function validatePhoneNumber() {
    var phoneNumber = document.getElementById("phonenumber").value;

    var phoneNumberRegex = "[0-9]+"
    if (!phoneNumber.match(phoneNumberRegex)) {
        alert("please enter a valid number");
    }

    if (phoneNumber.trim().length === 0) {
        alert("Please enter a phone number.");
        return false;
    }

}

function validateEmail() {
    var email = document.getElementById("email").value;
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!email.match(emailRegex)) {
        alert("Please enter a valid email address.");
        return false;
    }
    return true;
}

