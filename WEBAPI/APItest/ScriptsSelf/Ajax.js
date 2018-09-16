function getAll(){


    $.getJSON("http://localhost:49357/api/game",function(data) {
    
        
        var gameJSON = '';
            
        gameJSON += '<tr>';
        for (item of data) {
    
            gameJSON += '<td>' + item.ID + '</td>';
            gameJSON += '<td>' + item.Game_Name + '</td>';
            gameJSON += '<td>' + item.Player_one + '</td>';
            gameJSON += '<td>' + item.Player_two + '</td>';
            gameJSON += '<td>' + item.who_won + '</td>';
            gameJSON += '<tr>';
    }

       
     gameJSON += '</tr>';
    $('#Get').append(gameJSON);

})

};



function getWithId() {

    var id = $("#idGame").val();
    if (id>0) {
        $.getJSON("http://localhost:49357/api/game/"+id,function(data) {

            console.log(data);
            var gameJSON = '';
            
            gameJSON += '<tr>';
            gameJSON += '<td>' + data.ID + '</td>';
            gameJSON += '<td>' + data.Game_Name + '</td>';
            gameJSON += '<td>' + data.Player_one + '</td>';
            gameJSON += '<td>' + data.Player_two + '</td>';
            gameJSON += '<td>' + data.who_won + '</td>';
            gameJSON += '<tr>';
        
       
            gameJSON += '</tr>';
            $('#Get').append(gameJSON);
        }).then(()=>{ });
    }
    
}





$("#btnGetAll").click(function () {

    getAll();
});


        





$("#btnGetID").click(function () {
    getWithId();
});



$("#btndelet").click(function() {
    var id = $("#idDelet").val();
    if (id>0) {
        $.ajax({
            url: "http://localhost:49357/api/game/"+id ,
            type: "DELETE",
            contentType: "application/json",
            success: function() {
             
                getAll();
               
            },
            error: function() {
                alert("error");
            }
        });
    
    }
    
})






$("#btnPOST").click(function() {

    var obj=  { 
        Game_Name : $("#txtGameName").val(),
        Player_one: $("#txtPlayer1").val(),
        Player_two: $("#txtPlayer2").val(),
        who_won:$("#txtwhoWW").val()
    }



    $.post("http://localhost:49357/api/game",obj,function() {

        getAll();
               
    
    });
    
})



function toAddinput(data){
    document.getElementById("txtGameName").value = data.Game_Name;
    document.getElementById("txtPlayer1").value =data.Player_one;
    document.getElementById("txtPlayer2").value=data.Player_two;
    document.getElementById("txtwhoWW").value =data.who_won;



}

$("#btnGet").click(function() {
    
    var id = $("#idGame").val();
    if (id>0) {
        $.getJSON("http://localhost:49357/api/game/"+id,function(data) {
            toAddinput(data);

        });
    }
})


$("#btnPUT").click(function () {
    var id =$("#idGame").val();
   
    $.ajax({
        url: 'http://localhost:49357/api/game/'+id, 
        type:"PUT",
        data: { 
            Game_Name : $("#txtGameName").val(),
            Player_one: $("#txtPlayer1").val(),
            Player_two: $("#txtPlayer2").val(),
            who_won:$("#txtwhoWW").val()
        },
        success: function() 
        {
            getAll();
        }
    })

    
})




    