

var validArr = [false, false,false,false,false,false,false,false];






$("#btnLogin").on("click", function () {


    for (item in validArr) {
        if (validArr[item] == false) {
            return false;

        }
        return true;
    }



});



$("#txtNameFirst").on("input", function () {

    txtNameFirst = $(this);
    if (txtNameFirst.val().length>0) {

        txtNameFirst.addClass("is-valid");
        txtNameFirst.removeClass("is-invalid");
        validArr[0] = true;
        $("#lbltxtUserMaseeg").text("");
        return true;


    }
    validArr[0] = false;
    txtNameFirst.addClass("is-invalid");
    txtNameFirst.removeClass("is-valid");
    $("#lbltxtUserMaseeg").text("first Name  Can not be empty");

    return false;

    

});


$("#txtLastName").on("input", function () {

    txtLastName = $(this);
    if (txtLastName.val().length >0) {

        txtLastName.addClass("is-valid");
        txtLastName.removeClass("is-invalid");
        validArr[1] = true;
        $("#lblLastNameMaseeg").text("");
        return true;


    }
    validArr[1] = false;
    txtLastName.addClass("is-invalid");
    txtLastName.removeClass("is-valid");
    $("#lblLastNameMaseeg").text("Last Name  Can not be empty");
    return false;


});


$("#txtUser").on("input", function () {

    txtUser = $(this);
    
    if (txtUser.val().length>=9) {

        txtUser.addClass("is-valid");
        txtUser.removeClass("is-invalid");
        validArr[2] = true;
        $("#lbltxtUserMassge").text("");
        return true;


    }
    validArr[2] = false;
    txtUser.addClass("is-invalid");
    txtUser.removeClass("is-valid");
    $("#lbltxtUserMassge").text("User Name  Can not be empty and 9 Characters");
    return false;




});








$("#txtEmail").on("input", function () {

    txtEmail = $(this);
    if (txtEmail.val().includes("@")) {

        txtEmail.addClass("is-valid");
        txtEmail.removeClass("is-invalid");
        validArr[3] = true;
        $("#lblEmailMasseg").text("");
        return true;


    }
    validArr[3] = false;
    txtEmail.addClass("is-invalid");
    txtEmail.removeClass("is-valid");
    $("#lblEmailMasseg").text("the Email must be invalid and can't be empty")
    return false;

});

$("#txtPone").on("input", function () {

    txtPone = $(this);
    if ((isFinite(txtPone.val())&&(txtPone.val().length>=7))) {

        txtPone.addClass("is-valid");
        txtPone.removeClass("is-invalid");
        validArr[4] = true;
        $("#lblPhoneMasseg").text("");
        return true;


    }
    validArr[4] = false;
  
    txtPone.removeClass("is-valid");
    txtPone.addClass("is-invalid");
    $("#lblPhoneMasseg").text("the Phone must be 7 numbers");
    return false;



});
$("#txtPass").on("input", function () {

    regex = /[a-zA-Z]+$/
   
    txtPass = $(this);
    if ((txtPass.val().length>=9)&&(txtUser.val().search(regex) === -1)) {

        txtPass.addClass("is-valid");
        txtPass.removeClass("is-invalid");
        validArr[5] = true;
        $("#lblPasswordMasseg").text("");
        return true;


    }
    validArr[5] = false;
    txtPass.addClass("is-invalid");
    txtPass.removeClass("is-valid");
    $("#lblPasswordMasseg").text("Password Must be greater than to 9 characters and Can not be with characters ");
    return false;


});
$("#txtComperPass").on("input", function () {
    txtComperPass = $(this);
    txtPass = $("#txtPass").val();
    if (txtComperPass.val()==txtPass) {

        txtComperPass.addClass("is-valid");
        txtComperPass.removeClass("is-invalid");
        validArr[6] = true;
        $("#lblComperPassMasseg").text("");
        return true;


    }
    validArr[6] = false;
    txtComperPass.addClass("is-invalid");
    txtComperPass.removeClass("is-valid");
    $("#lblComperPassMasseg").text("the passwod must be Compare to passwod")
    return false;




});
$("#txtCardToBuy").on("input", function () {

    txtCardToBuy = $(this);
    if ((txtCardToBuy.val().length >= 16) && (isFinite(txtCardToBuy.val()))) {

        txtCardToBuy.addClass("is-valid");
        txtCardToBuy.removeClass("is-invalid");
        validArr[7] = true;
        $("#lblCreditMasseg").text("");
        return true;


    }
    validArr[7] = false;
    txtCardToBuy.addClass("is-invalid");
    txtCardToBuy.removeClass("is-valid");

    $("#lblCreditMasseg").text("Credit Card Cant be empty and must 16 numbers")
    return false;

});

