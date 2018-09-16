using DbServies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APItest.Controllers
{
    public class GameController : ApiController
    {
        private GamePlayerEntities db;

        // GET api/Game
        [HttpGet]
        [Route("api/game")]
        public HttpResponseMessage GetAllGame()
        {
            using (db = new GamePlayerEntities())
            {
                return Request.CreateResponse(HttpStatusCode.OK, db.Game.ToList());

            }



        }

        // GET api/Game/5
        [HttpGet]
        public HttpResponseMessage GetWithId(int id)
        {
            using (db = new GamePlayerEntities())
            {
                Game game = db.Game.FirstOrDefault(ID => ID.ID.Equals(id));
                if (game != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, game);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, game);
                }
            }
        }

        // POST api/Game
        [HttpPost]
        [Route("api/game")]
        public HttpResponseMessage Post([FromBody] Game game)
        {
            using (db = new GamePlayerEntities())
            {
               
                    db.Game.Add(game);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Accepted);
              
            }


        }

        // PUT api/Game/5
        public HttpResponseMessage Put(int id, [FromBody]Game gameBody)
        {
            using (db= new GamePlayerEntities())
            {
                Game game = db.Game.FirstOrDefault(ID => ID.ID.Equals(id));
                if (game !=null)
                {
                    
                    game.Player_one = gameBody.Player_one;
                    game.Player_two = gameBody.Player_two;
                    game.who_won = gameBody.who_won;
                    game.Game_Name = gameBody.Game_Name;
                    db.SaveChanges();
                    
                   return Request.CreateResponse(HttpStatusCode.Accepted);
                }
		        else
		            return Request.CreateResponse(HttpStatusCode.NotFound);
            }

                
          }



        

        // DELET api/Game/5
        public HttpResponseMessage Delete(int id)
        {
            using (db = new GamePlayerEntities())
            {
                Game game = db.Game.FirstOrDefault(ID => ID.ID.Equals(id));
                if (game != null)
                {
                    db.Game.Remove(game);
                    db.SaveChanges();

                    return Request.CreateResponse(HttpStatusCode.OK, "The game" + game.ID + "remove");
                }
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }



        }



        [HttpGet]
        [Route("api/game/search")]
        public HttpResponseMessage Get(int id = -1, string gameName = null, string playerOne = null, string playerTwo = null, string who_Won = null)
        {
            using (db = new GamePlayerEntities())
            {
                List<Game> listGame = db.Game
                    .Where(g => gameName != null ? g.Game_Name.ToLower().StartsWith(gameName.ToLower()) : true)

                    .Where(p1 => playerOne != null ? p1.Player_one.ToLower().StartsWith(playerOne.ToLower()) : true)
                    .Where(p2 => playerTwo != null ? p2.Player_two.ToLower().StartsWith(playerTwo.ToLower()) : true)
                    .Where(ww => who_Won != null ? ww.who_won.ToLower().StartsWith(who_Won.ToLower()) : true)
                    .Where(idGame => id > -1 ? idGame.ID.Equals(id) : true).ToList();


                if (listGame.Count > 0)
                    return Request.CreateResponse(HttpStatusCode.OK, listGame);
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }



    }
}
