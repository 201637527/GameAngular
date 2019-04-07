$("#btnBuy").on("click",function () {
    txtCard = $("#txtCard");
   
    if ((!txtCard.val().length == 0) && (!isNaN(txtCard.val())) && (txtCard.val() <= 11) && (txtCard.val() >0)) {
        return true;

    }

    $("#lblwarning").text("Tickets are available between 1 and 10");
  
    return false;
});