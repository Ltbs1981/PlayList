using PlayList.Web.Controller;

MusicController musicController = new MusicController();

musicController.Criar("Dont stop believin", "Teddy swins", 420);
musicController.Criar("Barracuda", "Heart", 240);
musicController.Criar("Fear of the dark", "Irom Madem", 302);
musicController.Criar("Bad lion", "Imagine Dragons", 310);
musicController.Criar("The unforgivem", "Metalica", 224);

musicController.Ler();


musicController.Editar(3, "The unforgivem 2");
musicController.Ler();
musicController.Delete(3);
musicController.Ler();
