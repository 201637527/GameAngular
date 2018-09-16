

let button = $("#GetObservableclick");
let obs = Rx.Observable.fromEvent(button,"click");
obs.subscribe(
    {
    
        next:(val) => alert("Observable click"+"  " +val),
        error:()=>alert("error"),
        complete:()=> alert("complete")

    }
);

                
       
     

   let obs1 =Rx.Observable.ajax.get("http://localhost:49357/api/game");
   $("#GetObservable").mouseover(function() {
     
       
       obs1.subscribe({
           next:(val) => alert("Observable mouseover"+"  " +val),
           error:()=>alert("error"),
           complete:()=> getAll()
       });
    
   });




