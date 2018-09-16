$("#btnTrue").click(function () {
    var trueClinet = true;
    var api = new API(trueClinet);


})

$("#btnFalse").click(function () {
    var falseClinet = false;
    var api = new API(falseClinet);
  
    
})




function API(mock) {
    if (mock)
    {
        
        var pTrue =  $.getJSON('http://localhost:49357/api/game',function(data) {putInTable(data)})
        console.log(pTrue);
        return pTrue;
    }
    else {
    
        
        var p = new Promise((resolve,reject) => 
        {
            var clinetDemo = [new DemoGame(1, "fier", "moshe", "David", "David"),new DemoGame(2,"bold","Gili","Shalom","Shalom")];
            putInTable(clinetDemo);
            resolve(clinetDemo);
            //reject(alert("reject error"));
        });
        return p
    }

    

}
function DemoGame(ID, Game_Name, Player_one, Player_two, who_won) {
    this.ID = ID;
    this.Game_Name = Game_Name;
    this.Player_one = Player_one;
    this.Player_two = Player_two;
    this.who_won = who_won;

}

function putInTable(arrGame) {
    
    var game = '';           
    game += '<tr>';
    for (item of arrGame) {
    
        game += '<td>' + item.ID + '</td>';
        game += '<td>' + item.Game_Name + '</td>';
        game += '<td>' + item.Player_one + '</td>';
        game+= '<td>' + item.Player_two + '</td>';
        game += '<td>' + item.who_won + '</td>';
        game += '<tr>';
    }

       
    game += '</tr>';
    $('#Get').append(game);

};
    
