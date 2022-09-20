using Sheff;
using static Sheff.SaladActivities;

BellPepper pepper = new("Big French");
SaladLeaves leaves = new("Iceberg");
Tuna tuna = new("Norway express");
Salt salt = new("Rockwell", Salt.Type.NaCl);
Oil oil1 = new("Olivine", Oil.Type.OliveOil);
Oil oil2 = new("White diamonds", Oil.Type.SeasameOil);
TunaOil oil3 = new TunaOil("SlickTunes");
Ingredient[] ing1 = new Ingredient[] { pepper, leaves, tuna, salt, oil1, oil2, oil3 };
Ingredient[] ing2 = new Ingredient[] { pepper, salt, oil1 };

// Cooking salad
PrepareSalad(ing1);
PrepareSalad(ing2);
// Counting calories
CountCalories(ing1);
// Searching for oil
ing1.SearchForOil();