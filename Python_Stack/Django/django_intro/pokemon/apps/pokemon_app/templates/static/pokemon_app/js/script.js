
$(document).ready(function(){
    $.get("https://pokeapi.co/api/v2/pokemon/1/", function(res) {
        var html_str = "";
        html_str += "<h4>Types</h4>";
        html_str += "<ul>";
        for(var i = 0; i < res.types.length; i++) {
            html_str += "<lil>" + res.types[i].type.name + "</li>";
        }
        html_str += "</ul>";
        $("#bulbasaur").html(html_str);
    }, "json");

    $.get("https://pokeapi.co/api/v2/pokemon/2/", function(res){
        console.log(res)
    }, "json");


    for(var i = 1; i < 156; i++) {
        $.get("https:pokeapi.co/api/v2/pokemon/" + i, function(res) {
            var stringToList = "";
            stringToList += "<option>" + res.name + "</option>";
            $("listOfNames").html(stringToList)
        }, "json");
    }
    
})

var pokeList = [];
for(var i = 1; i <= 151; i++) {
    pokeList.push("https://pokeapi.co/api/v2/pokemon/" + i + "/");
}

Console.log(pokelist[2]);