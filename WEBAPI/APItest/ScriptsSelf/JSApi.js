

function getGame() {
   
    var req = new XMLHttpRequest();
    
    req.open('GET',"http://localhost:49357/api/game")
    req.onload = function () {


        var data = JSON.parse(req.response);
        
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
    
     
    }
req.onerror = function () {
    alert('error')
}
req.send()
}

function getGameID() {
    var id = document.getElementById("idGame").value;
  
    if (id > 0) {
        var req = new XMLHttpRequest();
        req.open('GET', "http://localhost:49357/api/game/"+id)
        req.onload = function () {


            var data = JSON.parse(req.response);
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
    
     
    }
       
        req.onerror = function () {
            alert('error')
        }
        req.send();
    }
}
    







function delet() {
    var id = document.getElementById("idDelet").value;
    if (id > 0) {
        var req = new XMLHttpRequest();

        req.open('DELETE', "http://localhost:49357/api/game/" + id)
        req.onload = function () {
            getGame();

        }
        req.onerror = function () {
            alert('error')
        }
        req.send()
    }
}









function post(){

    var game = {
        Game_Name: document.getElementById("txtGameName").value,
        Player_one : document.getElementById("txtPlayer1").value,
        Player_two : document.getElementById("txtPlayer2").value,
        who_won : document.getElementById("txtwhoWW").value

    }
    
    var req = new XMLHttpRequest();

    req.open('POST', "http://localhost:49357/api/game")
    req.setRequestHeader("Content-Type", "application/json")
    req.onload = function () {
        getGame();

    }
    req.onerror = function () {
        alert('error')
    }
    req.send(JSON.stringify(game))
}




function getIDBeforeChange() {

    var id = document.getElementById("idGame").value;
  
    if (id > 0) {
        var req = new XMLHttpRequest();
        req.open('GET', "http://localhost:49357/api/game/"+id)
        req.onload = function () {


            var data = JSON.parse(req.response);
           
            var gameJSON = '';
            
            gameJSON += '<tr>';
           
    
            document.getElementById("idGame").value= data.ID;
            document.getElementById("txtGameName").value =  data.Game_Name ;
            document.getElementById("txtPlayer1").value= data.Player_one ;
            document.getElementById("txtPlayer2").value=data.Player_two;
            document.getElementById("txtwhoWW").value= data.who_won;
            
            getGameID();
    
     
        }
       
        req.onerror = function () {
            alert('error')
        }
        req.send();
    }
}
    














function put() {
   
    var id = document.getElementById("idGame").value;
    var game = {
        Game_Name: document.getElementById("txtGameName").value,
        Player_one: document.getElementById("txtPlayer1").value,
        Player_two: document.getElementById("txtPlayer2").value,
        who_won: document.getElementById("txtwhoWW").value

    }

    var req = new XMLHttpRequest();

    req.open('put', "http://localhost:49357/api/game/" + id)
    req.setRequestHeader("Content-Type", "application/json")
    req.onload = function () {
        getGame();

    }
    req.onerror = function () {
        alert('error')
    }
    req.send(JSON.stringify(game))
}



