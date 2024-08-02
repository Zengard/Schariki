mergeInto(LibraryManager.library, {

    /*
    //виндовс алекрт - всплывающее поверх браузера окно с предупреждением
    Hello: function () {
        window.alert("Hello, world!");
        console.log("Тут был Вася 123");
    },
    */

    PlayerData: function () {
       
        console.log(player.getName());
        console.log(player.getPhoto("medium"));
       
        
        //myGameInstance.SendMessage('Yandex', 'Set_text_nik', player.getName());
        myGameInstance.SendMessage('Yandex', 'SetNik', player.getName());
        myGameInstance.SendMessage('Yandex', 'Set_Image', player.getPhoto("medium"));
       
    },


});