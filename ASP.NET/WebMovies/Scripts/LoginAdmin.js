$("#btnLgin").click(function () {



    for (i in validArr) {
        if ((validArr[i] == false) && (i == 0)) {
            return false;
        }

        return true;

    }
});

var validArr = [false, false];
$('#txtUsername').on('input', function () {
    user = $(this);
    if (user.val().length >= 9) {
        user.removeClass("is-invalid");
        user.addClass("is-valid");
        $("#lblerroe1").text("");

        validArr[0] = true
        return true
    }
    user.addClass("is-invalid");
    user.removeClass("is-valid");
    $("#lblerroe1").text("UserName Must be greater than to 9 characters").css("color", "red");

    validArr[0] = false
    return false
});
$('#txtPASS').on('input', function () {
    regex = /[a-zA-Z]+$/
    pass = $(this);
    if ((pass.val().length >= 9) && (pass.val().search(regex) === -1)) {
        pass.removeClass("is-invalid");
        pass.addClass("is-valid");
        $("#lblerroe2").text("");
        validArr[1] = true
        return true
    }
    pass.addClass("is-invalid");
    pass.removeClass("is-valid");

    $("#lblerroe2").text("password Must be greater than to 9 characters and Can not be with characters").css("color", "red");

    validArr[1] = false
    return false
});


