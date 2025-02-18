/*using System;
using System.Collections.Generic;

// Meal Plan Interface
interface IMealPlan
{
    string GetMealType();
}

// Vegetarian Meal
class VegetarianMeal : IMealPlan
{
    public string GetMealType() => "Vegetarian Meal";
}

// Vegan Meal
class VeganMeal : IMealPlan
{
    public string GetMealType() => "Vegan Meal";
}

// Keto Meal
class KetoMeal : IMealPlan
{
    public string GetMealType() => "Keto Meal";
}

// High-Protein Meal
class HighProteinMeal : IMealPlan
{
    public string GetMealType() => "High-Protein Meal";
}

// Generic Meal class
class Meal<T> where T : IMealPlan
{
    public string MealName { get; }
    public T MealCategory { get; }

    public Meal(string mealName, T mealCategory)
    {
        MealName = mealName;
        MealCategory = mealCategory;
    }

    public void DisplayMeal()
    {
        Console.WriteLine($"Meal: {MealName} | Type: {MealCategory.GetMealType()}");
    }
}

// Meal Plan Generator
class MealPlanGenerator
{
    public static void GenerateMealPlan<T>(T meal) where T : IMealPlan
    {
        Console.WriteLine($"Generated Meal Plan: {meal.GetMealType()}");
    }
}

class Program
{
    static void Main()
    {
        // Create different meals
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>("Grilled Vegetables", new VegetarianMeal());
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>("Tofu Stir-Fry", new VeganMeal());
        Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>("Keto Salad", new KetoMeal());
        Meal<HighProteinMeal> proteinMeal = new Meal<HighProteinMeal>("Chicken Breast", new HighProteinMeal());

        // Display meals
        vegMeal.DisplayMeal();
        veganMeal.DisplayMeal();
        ketoMeal.DisplayMeal();
        proteinMeal.DisplayMeal();

        // Generate meal plans
        MealPlanGenerator.GenerateMealPlan(new VegetarianMeal());
        MealPlanGenerator.GenerateMealPlan(new VeganMeal());
        MealPlanGenerator.GenerateMealPlan(new KetoMeal());
        MealPlanGenerator.GenerateMealPlan(new HighProteinMeal());
    }
}
*/