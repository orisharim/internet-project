function validateForm() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    var usernameRegex = /^[a-zA-Z0-9_]{3,}$/;
    if (!username.match(usernameRegex)) {
        alert("Username must be at least 3 characters long and can only contain letters, numbers, and underscores.");
        return false;
    }
    
    if (password.length < 4) {
        alert("Password must be at least 4 characters long");
        return false;
    }
    return true;
}
