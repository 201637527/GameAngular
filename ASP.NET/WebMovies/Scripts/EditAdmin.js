
arrvalid = [false, false, false, false]



$("#linkInsert").click(function () {
    for (item in arrvalid) {

        if (arrvalid[item]==false) {
            return false
        }
        return true;

    }
   

});




$("#txtInventoryInsert").on('input', function () {
    txtInventoryInsert = $(this);
    if (isNaN(txtInventoryInsert.val()) || (txtInventoryInsert.val() == "")) {
        txtInventoryInsert.removeClass("is-valid");
        txtInventoryInsert.addClass("is-invalid");

        $("#lblerroe5").text("Inventory must be nonnegative and must be number").css("color", "red");
        arrvalid[0] = false;
        return false
    }
    txtInventoryInsert.addClass(" is-valid");
    txtInventoryInsert.removeClass(" is-invalid");
    $("#lblerroe5").text("");

    arrvalid[0] = true;
    return true
});



$("#txtNameMoviesIsert").on('input', function () {
    txtNameMoviesIsert = $(this);
    if (txtNameMoviesIsert.val() == "") {
        txtNameMoviesIsert.removeClass(" is-valid");
        txtNameMoviesIsert.addClass("  is-invalid");
        $("#lblerroe1").text("The name of movies can't be empty").css("color", "red");

        arrvalid[1] = false;
        return false
    }
    txtNameMoviesIsert.addClass(" is-valid");
    txtNameMoviesIsert.removeClass(" is-invalid");
    $("#lblerroe1").text("");

    arrvalid[1] = true;
    return true
});



$("#txtMovieDirectorIsert").on('input', function () {
    txtMovieDirectorIsert = $(this);
    if (txtMovieDirectorIsert.val() == "") {
        txtMovieDirectorIsert.removeClass(" is-valid");
        txtMovieDirectorIsert.addClass("  is-invalid");
        $("#lblerroe3").text("The name of Director can't be empty").css("color", "red");

        arrvalid[2] = false;
        return false
    }
    txtMovieDirectorIsert.addClass(" is-valid");
    txtMovieDirectorIsert.removeClass(" is-invalid");
    $("#lblerroe3").text("");
    arrvalid[2] = true;

    return true
});


$("#txtDescriptionIsert").on('input', function () {
    txtDescriptionIsert = $(this);
    if (txtDescriptionIsert.val() == "") {
        txtDescriptionIsert.removeClass(" is-valid");
        txtDescriptionIsert.addClass("  is-invalid");
        $("#lblerroe4").text("The name of Description can't be empty").css("color", "red");
        arrvalid[3] = false;
        return false
    }
    txtDescriptionIsert.addClass(" is-valid");
    txtDescriptionIsert.removeClass(" is-invalid");
    $("#lblerroe4").text("");
    arrvalid[3] = true;
    return true
});











$("#gvAdmin").click(function () {


    if (($("#txtNameMoviesEdit").val() != "") && ($("#txtMovieDirector").val() != "") && ($("#txtDescription").val() != "") && ($("#txtInventory").val() != "")) {
        return true;
    }
    
    return false;
 
           
});






$("#txtNameMoviesEdit").on("input", function () {
    
    txtNameMoviesEdit = $(this);
    if (txtNameMoviesEdit.val() == "") {

        txtNameMoviesEdit.removeClass("is-valid");
        txtNameMoviesEdit.addClass("is-invalid");
        $("#lblMaseEr1").text("The name of Director can't be empty").css("color", "red");
     
        return false;

       
    }
    {
        txtNameMoviesEdit.addClass("is-valid");
        txtNameMoviesEdit.removeClass("is-invalid");
    $("#lblMaseEr1").text("");

    return true
    }
});





$("#txtMovieDirector").on("input", function () {

    txtMovieDirector = $(this);
    if (txtMovieDirector.val() == "") {

        txtMovieDirector.removeClass("is-valid");
        txtMovieDirector.addClass("is-invalid");
        $("#lblMaseEr2").text("The name of Director can't be empty").css("color", "red");
        
        return false;


    }
    {
        txtMovieDirector.addClass("is-valid");
        txtMovieDirector.removeClass("is-invalid");
        $("#lblMaseEr2").text("");
   
        return true
    }
});


$("#txtDescription").on("input", function () {

    txtDescription = $(this);
    if (txtDescription.val() == "") {

        txtDescription.removeClass("is-valid");
        txtDescription.addClass("is-invalid");
        $("#lblMaseEr3").text("The name of Director can't be empty").css("color", "red");
      
        return false;


    }
    {
        txtDescription.addClass("is-valid");
        txtDescription.removeClass("is-invalid");
        $("#lblMaseEr3").text("");
 
        return true
    }
});


$("#txtInventory").on("input", function () {

    txtInventory = $(this);
    if ((txtInventory.val() == "") || (isNaN(txtInventory.val()))) {

        txtInventory.removeClass("is-valid");
        txtInventory.addClass("is-invalid");
        $("#lblMaseEr4").text("The name of Director can't be empty").css("color", "red");
  
        return false;


    }
    {
        txtInventory.addClass("is-valid");
        txtInventory.removeClass("is-invalid");
        $("#lblMaseEr4").text("");
      
        return true
    }
});



