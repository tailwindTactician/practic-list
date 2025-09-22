List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine(numbers1.Sum());

        List<string> strings1 = new List<string> { "apple", "banana", "kiwi", "pear" };
        List<string> sortedStrings1 = strings1.OrderByDescending(s => s.Length).ToList();
        Console.WriteLine(string.Join(", ", sortedStrings1));

        List<Person> persons1 = new List<Person>
        {
            new Person(){Name="Ali", Age=25},
            new Person(){Name="Sami", Age=19},
            new Person(){Name="Karim", Age=30}
        };
        List<Person> sortedPersons1 = persons1.OrderBy(p => p.Age).ToList();
        foreach (Person p in sortedPersons1) Console.WriteLine($"{p.Name} {p.Age}");

        List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6 };
        numbers2.RemoveAll(n => n % 2 != 0);
        Console.WriteLine(string.Join(", ", numbers2));

        List<string> strings2 = new List<string> { "hello", "world", "test" };
        List<string> upperStrings = strings2.Select(s => s.ToUpper()).ToList();
        Console.WriteLine(string.Join(", ", upperStrings));

        List<int> numbers3 = new List<int> { 10, 3, 25, -4, 7 };
        Console.WriteLine($"Max: {numbers3.Max()}, Min: {numbers3.Min()}");

        List<string> strings3 = new List<string> { "abc", "hello", "world", "uniq" };
        foreach (string s in strings3)
            Console.WriteLine($"{s}: {s.Length == s.Distinct().Count()}");

        List<Person> persons2 = new List<Person>
        {
            new Person(){Name="Aziz", Age=20},
            new Person(){Name="Said", Age=40},
            new Person(){Name="Olim", Age=30}
        };
        Console.WriteLine(persons2.Average(p => p.Age));

        List<int> numbers4 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        List<int> uniqueNumbers = numbers4.Distinct().ToList();
        Console.WriteLine(string.Join(", ", uniqueNumbers));

        List<string> strings4 = new List<string> { "aba", "hello", "level" };
        foreach (string s in strings4)
            Console.WriteLine($"{s}: {s == new string(s.Reverse().ToArray())}");

        List<Person> persons3 = new List<Person>
        {
            new Person(){Name="Ali", Age=25},
            new Person(){Name="Sami", Age=30}
        };
        List<Person> filtered = persons3.Where(p => p.Age == 30).ToList();
        foreach (Person p in filtered) Console.WriteLine($"{p.Name} {p.Age}");

        List<string> strings5 = new List<string> { "one", "two", "three" };
        Console.WriteLine(string.Join(";", strings5));

        List<int> numbers5 = new List<int> { 5, 10, 15, 20, 25 };
        int sumOddIndex = numbers5.Where((n, i) => i % 2 == 1).Sum();
        Console.WriteLine(sumOddIndex);

        List<string> strings6 = new List<string> { "short", "longer", "longestword" };
        Console.WriteLine(strings6.OrderByDescending(s => s.Length).First());

        List<Person> persons4 = new List<Person>
        {
            new Person(){Name="Karim", Age=25},
            new Person(){Name="Ali", Age=20},
            new Person(){Name="Zafar", Age=30}
        };
        List<Person> sortedPersons2 = persons4.OrderBy(p => p.Name).ToList();
        foreach (Person p in sortedPersons2) Console.WriteLine($"{p.Name} {p.Age}");

        List<int> numbers6 = new List<int> { 1, 2, 3, 4, 5 };
        int target = 6;
        for (int i = 0; i < numbers6.Count; i++)
        {
            for (int j = i + 1; j < numbers6.Count; j++)
            {
                if (numbers6[i] + numbers6[j] == target)
                    Console.WriteLine($"{numbers6[i]} + {numbers6[j]} = {target}");
            }
        }

        List<Person> persons5 = new List<Person>
        {
            new Person(){Name="A", Age=20},
            new Person(){Name="B", Age=40},
            new Person(){Name="C", Age=30}
        };
        double avgAge = persons5.Average(p => p.Age);
        List<Person> olderThanAvg = persons5.Where(p => p.Age > avgAge).ToList();
        foreach (Person p in olderThanAvg) Console.WriteLine($"{p.Name} {p.Age}");

        List<string> strings7 = new List<string> { "apple", "banana", "grape" };
        strings7.RemoveAll(s => s.Contains("a"));
        Console.WriteLine(string.Join(", ", strings7));

        List<int> numbers7 = new List<int> { -5, 10, -15, 20 };
        List<int> absNumbers = numbers7.Select(n => Math.Abs(n)).ToList();
        Console.WriteLine(string.Join(", ", absNumbers));

        List<Person> persons6 = new List<Person>
        {
            new Person(){Name="Ali", Age=25},
            new Person(){Name="Sami", Age=30},
            new Person(){Name="Olim", Age=25}
        };
        var groups = persons6.GroupBy(p => p.Age);
        foreach (var g in groups)
        {
            Console.WriteLine($"Age {g.Key}: {string.Join(", ", g.Select(p => p.Name))}");
        }
    