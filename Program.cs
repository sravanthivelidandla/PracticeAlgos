using PracticeAlgos._15daysPractice;
using PracticeAlgos.BinarySearch;
using PracticeAlgos.Day12;
using PracticeAlgos.Day2;
using PracticeAlgos.Day31;
using PracticeAlgos.Day4;
using PracticeAlgos.Day5;
using PracticeAlgos.Day6;
using PracticeAlgos.Day7;
using PracticeAlgos.Day8;
using PracticeAlgos.FacebookInterviewQuestions;
using PracticeAlgos.MicrosoftIQ;
using PracticeAlgos.PalindromicStrings;
using PracticeAlgos.Tries;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            new LongestSubstringWORepeatingChars().getLengthOfLongestSubstring();

            new CourseScheduler().canFinishCourses();

            new TimeTakenToInformEmployees().timeTakenToInform();
            
            new WallsAndGates().fillDistanceMatrix();
            //new RottenOranges().calcTimeTakenToRottenOranges();
//            new NumberOfIslands().getNumberOfIslands();
            //new SearchWordsInDocument().searchDocument();

            //new NextPermutation().getNextPermutation();

            //new MaxConsecutive1s().maxConsecutive1s();

            //Prateek udemy
            // new NQueens().solveQueens();

            //new SudokuSolver().SolveSudokuProblem();

            //new DiceThrow().diceThrow(4);
            //new DiceThrow().diceThrow(5);

            //new LetterCombinationsOfPhoneNumber().phonePad("12");
            //new LetterCombinationsOfPhoneNumber().phonePad("123");

            // new Permutation().printPermutationsOfString("abc");
            // new Permutation().printPermutationsOfString("abcd");

            // Console.WriteLine(new RotatedSortedArray().search(new int[] { 10, 12, 1, 2, 3, 4, 5, 6 }, 3));
            // Console.WriteLine(new RotatedSortedArray().search(new int[] { 7,8,9,10, 12, 1, 2, 3, 4, 5, 6 }, 9));
            // Console.WriteLine(new RotatedSortedArray().search(new int[] { 7, 8, 9, 10, 12, 1, 2, 3, 4, 5, 6 }, 5));

            // Console.WriteLine(new MountainArray().SearchElement(new int[] { 1, 2, 3, 4, 3, 2, 1 },3));
            // Console.WriteLine(new MountainArray().SearchElement(new int[] { 0, 1, 2, 0, 1 },1));
            //// Console.WriteLine(new MountainArray().SearchElement(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },4));

            // Console.WriteLine(new MountainArray().findElement(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            // Console.WriteLine(new MountainArray().findElement(new int[] { 0, 1, 2, 0, 1 }));
            // Console.WriteLine(new MountainArray().findElement(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }));

            // Console.WriteLine(new MountainArray().findIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }));
            // Console.WriteLine(new MountainArray().findIndex(new int[] { 0,1,2,0,1}));
            // Console.WriteLine(new MountainArray().findIndex(new int[] { 1,2,3,4,5,6,7,8 }));

            //Console.WriteLine(new InfiniteArray().positionOfItem(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, 15));
            //Console.WriteLine(new InfiniteArray().positionOfItem(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, 18));
            //Console.WriteLine(new InfiniteArray().positionOfItem(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, 14));
            //Console.WriteLine(new InfiniteArray().positionOfItem(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, 9));

            //new FirstLastItemPosition().findItemPosition(new int[] { 1, 2, 4, 4, 4, 4, 4, 4, 5, 6, 7 }, 4);


            //new NextGreatestLetter().nextGreatestLetter(new char[] { 'a','b','c'}, 't');
            //new NextGreatestLetter().nextGreatestLetter(new char[] { 'a', 'b', 'c' }, 'b');
            //new NextGreatestLetter().nextGreatestLetter(new char[] { 'a', 'b', 'c' }, 'z');

            // new Floor().floorOfNumber (new int[] { 2, 3, 5, 9, 14, 16, 18 }, 15);
            // new Floor().floorOfNumber(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 9);
            // new Floor().floorOfNumber(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 4);

            // new Ceiling().ceilingOfNum(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 15);
            // new Ceiling().ceilingOfNum(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 9);
            // new Ceiling().ceilingOfNum(new int[] { 2, 3, 5, 9, 14, 16, 18 }, 4);

            // new SubSet().printSubset("abc");

            // Console.WriteLine(new RemoveChars().skipAppNotApple("aabbcappdeasdg"));

            // Console.WriteLine(new RemoveChars().replaceChars("aabbcdeasdg"));
            //// microsoft();

            // Console.WriteLine("{0}", ReverseWords("hi hello i am Sravanthi      "));
            //Console.WriteLine("{0}", atoi("21474836460"));

            // dpEducative();

            // WordBreak();


            decodeWays();

            //twoSum();
            //threeSum();


            // Tries();

            //Nextflix educative.io
            //NIQs();

            //Facebook
            // FIQs();
            // Day31(); //Trees
            //Day8();

            //Day7();

            //Day6Problems();

            //Day5();
            #region practice Day1 - Day4

            //Day4 Strings
            //Strings str = new Strings();

            //Console.WriteLine(str.paranthesisMatch("[BC]A{D}F"));
            //Console.WriteLine(str.paranthesisMatch("([BC]A{D}F)"));
            //Console.WriteLine(str.paranthesisMatch("([BC]AD}F"));

            //Console.WriteLine(str.returnColumnNumber("BC")); //55
            //Console.WriteLine(str.returnColumnNumber("BZ")); //78
            //Console.WriteLine(str.returnColumnNumber("AAC")); //705

            //Console.WriteLine(str.returnColumnName(78)); //BZ
            //Console.WriteLine(str.returnColumnName(51)); //AY
            //Console.WriteLine(str.returnColumnName(52)); //AZ
            //Console.WriteLine(str.returnColumnName(54)); //BB
            //Console.WriteLine(str.returnColumnName(80)); //CB
            //Console.WriteLine(str.returnColumnName(84)); //CF
            //Console.WriteLine(str.returnColumnName(676)); //YZ
            //Console.WriteLine(str.returnColumnName(702)); //ZZ
            //Console.WriteLine(str.returnColumnName(705)); //AAC

            //Console.WriteLine(str.checkIfSubstring("waterbottle", "erbottlewat"));
            //Console.WriteLine(str.checkIfSubstring("waterbottles", "elttobretaw"));

            //Console.WriteLine(str.replaceAllOccurancesOfString2("hello world", "ld"));



            //Day2
            //LinkedLists ll = new LinkedLists();
            //ll.add(1);
            //ll.add(2);
            //ll.add(1);
            //ll.add(1);
            //ll.add(2);
            //ll.add(3);
            //ll.add(5);
            //ll.add(4);
            //Node h = ll.add(5);

            //Console.WriteLine(ll.removeDuplicatesUnSortedListWithNoAdditionalSpace(h));           
            //ll.displayLinkedList();

            //LinkedLists l2 = new LinkedLists();
            //l2.add(1);
            //l2.add(2);
            //l2.add(4);
            //l2.add(5);
            //l2.add(7);
            //Node h1 = l2.add(9);
            // ll.displayLinkedList();
            //ll.reverseLinkedListIterative(h);
            //ll.reverseLinkedListRecursive(h);
            //ll.reverseLinkedListWithStack(h);

            // ll.MergeLinkedLists(h, h1);

            // Console.WriteLine(ll.hasCycle(h));
            //  Console.WriteLine(ll.length(h));
            //ll.displayLinkedList();

            //Console.Write(ll.removeDuplicates(h));


            //Day1();
            //reverseString();


            //Console.WriteLine("Enter the string to validate: ");
            //string inputArgs = Console.ReadLine();
            //Console.WriteLine("Enter flipCount");
            //int length = Convert.ToInt32(Console.ReadLine());

            //int maxLength = new LRCSubstring().maxSubStringLength(inputArgs, length);

            //Console.WriteLine("max Substring length is :"+ maxLength);

            //bool isValid = isValidParanthesis(inputArgs);
            //if (isValid)
            //    Console.WriteLine("Valid Paranthesis");
            //else
            //    Console.WriteLine("InValid Paranthesis");
            #endregion
            Console.ReadKey();
        }

        private static void microsoft()
        {
            //ValidParanthesis vp = new ValidParanthesis();
            //Console.WriteLine(vp.IsValid("(){}[]"));
            //Console.WriteLine(vp.IsValid("()}[]"));
            //Console.WriteLine(vp.IsValid("]]]{{{"));

            MissingNum number = new MissingNum();
            Console.WriteLine(number.SingleNumber(new int[] { 1, 2, 3, 1, 2 }));
            Console.WriteLine(number.SingleNumber(new int[] { 1, 2, 4,4,5,5,7, 1, 2 }));

        }

        public static string ReverseWords(string s)
        {
            if (string.IsNullOrEmpty(s)) 
            return null;

            return String.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }


            static int atoi(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            s = s.Replace(" ", "").ToLower();
            char[] chars = s.ToCharArray();
            int result = 0;

            int sign = 0;
            bool findDigit = false, findSign = false;
            foreach (char ch in chars)
            {
                if (!findDigit && !findSign && (ch == '+' || ch == '-'))
                {
                    findSign = true;
                    sign = (ch == '+') ? 1 : -1;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    findDigit = true;
                    if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && ch - '0' > 7))
                        if (sign == -1)
                            return int.MinValue;
                        else
                            return int.MaxValue;


                    result = result * 10 + (ch - '0');
                }

                else if ((findSign || findDigit && ch == ' ') || findDigit && ch == '.' || ch == ' ')
                {
                    return result * sign;
                }
            }
            return result * sign;
        }

        private static void dpEducative()
        {

            MinimumPalindromeCuts mpp = new MinimumPalindromeCuts();
            Console.WriteLine(mpp.mpCuts("abdbca"));

            PalindromeDeletion pd = new PalindromeDeletion();
            Console.WriteLine(pd.minDeletions("dfseabbcbbaeewer"));
            Console.WriteLine(pd.minDeletions("abcde"));

            //LPSubstring lps = new LPSubstring();
            //Console.WriteLine(lps.lpSubstring("dfseabbcbbaeewer"));
            //Console.WriteLine(lps.lpSubstring("abcde"));

            //LPS lps = new LPS();
            //Console.WriteLine(lps.lps("abbcbbae"));
            //Console.WriteLine(lps.lps("abcde"));


            //HouseRobbery ht = new HouseRobbery();
            //int[] wealth = { 2, 5, 1, 3, 6, 2, 4 };
            //Console.WriteLine(ht.stealMaxWealth(wealth));
            //wealth = new int[] { 2, 10, 14, 8, 1 };
            //Console.WriteLine(ht.stealMaxWealth(wealth));

            //JumpGameII jump = new JumpGameII();
            //Console.WriteLine(jump.MinJumpsRequired(new int[] { 1, 2, 3, 4, 5, 6 }));
            //Console.WriteLine(jump.MinJumpsRequired(new int[] { 2, 1, 0, 1, 4 }));

            //JumpGame
            //JumpGameI jump = new JumpGameI();
            //Console.WriteLine(jump.canJump(new int[]{1,2,3,4,5,6}));
            //Console.WriteLine(jump.canJump(new int[] { 1, 0, 3, 4, 5, 6 }));

            //Stairs
            //StairsToBeTaken sc = new StairsToBeTaken();
            //Console.WriteLine(sc.CountWays(3));
            //Console.WriteLine(sc.CountWays(4));
            //Console.WriteLine(sc.CountWays(5));


            //MaxRibbonCut cr = new MaxRibbonCut();
            //int[] ribbonLengths = { 2, 3, 5 };
            //Console.WriteLine(cr.maxRibbonCutSolver(ribbonLengths, 5));
            //ribbonLengths = new int[] { 2, 3 };
            //Console.WriteLine(cr.maxRibbonCutSolver(ribbonLengths, 7));
            //ribbonLengths = new int[] { 3, 5, 7 };
            //Console.WriteLine(cr.maxRibbonCutSolver(ribbonLengths, 13));
            //ribbonLengths = new int[] { 3, 5 };
            //Console.WriteLine(cr.maxRibbonCutSolver(ribbonLengths, 7));

            //CoinChange cc = new CoinChange();
            //int[] denominations = { 1, 2, 3 };
            //Console.WriteLine((cc.waysToGetCoinChange(denominations, 5)));

            //RodCutting rc = new RodCutting();
            //int[] lengths = { 1, 2, 3, 4, 5 };
            //int[] prices = { 2, 6, 7, 10, 13 };
            //int maxProfit = rc.rodCutting( prices,lengths, 5);
            //Console.WriteLine(maxProfit);

            //UnboundedKnapsack ks = new UnboundedKnapsack();
            //int[] profits = { 15, 50, 60, 90 };
            //int[] weights = { 1, 3, 4, 5 };
            //int maxProfit = ks.solveKnapsack(profits, weights, 8);
            //Console.WriteLine(maxProfit);


            //TargetSum ts = new TargetSum();
            //int[] num = { 1, 1, 2, 3 };
            //Console.WriteLine(ts.targetSum(num, 1));
            //num = new int[] { 1, 2, 7, 1 };
            //Console.WriteLine(ts.targetSum(num, 9));

            // PartitionSet ps = new PartitionSet();
            //int[] num = { 1, 2, 3, 9 };
            //Console.WriteLine(ps.canPartition(num));
            //num = new int[] { 1, 2, 7, 1, 5 };
            //Console.WriteLine(ps.canPartition(num));
            //num = new int[] { 1, 3, 100, 4 };
            //Console.WriteLine(ps.canPartition(num));
        }

        private static void WordBreak()
        {
            Console.Write(new WordBreak().wordBreak("leetcode", new List<string>() { "leet", "code" }));
        }

        private static void decodeWays()
        {
            Console.WriteLine(new DecodeWays().decodeWays("11211"));
            Console.WriteLine(new DecodeWays().decodeWays("1120"));
            Console.WriteLine(new DecodeWays().decodeWays("1201"));
            Console.WriteLine(new DecodeWays().decodeWays("112060"));
            Console.WriteLine(new DecodeWays().decodeWays("112111121111"));

            Console.WriteLine(new DecodeWays().decodeWaysII("11211"));
            Console.WriteLine(new DecodeWays().decodeWaysII("1120"));
            Console.WriteLine(new DecodeWays().decodeWaysII("1201"));
            Console.WriteLine(new DecodeWays().decodeWaysII("112060"));
            Console.WriteLine(new DecodeWays().decodeWaysII("112111121111"));
        }
        private static void threeSum()
        {
           List<List<int>> result = new ThreeSum().threeSum(new int[] { 1, 2, 3, 4, 5, 6 }, 11);
            foreach (List<int> r in result)
                foreach(int res in r)
                Console.Write(res + ",");
            Console.WriteLine();
            result = new ThreeSum().threeSum(new int[] { 1, 2, 3, 4, 5, 6 }, 15);
            foreach (List<int> r in result)
                foreach (int res in r)
                    Console.Write(res + ",");
            Console.WriteLine();
            result = new ThreeSum().threeSum(new int[] { 1, 2, 3, 4, 5, 6 }, 8);
            foreach (List<int> r in result)
                foreach (int res in r)
                    Console.Write(res + ",");
            Console.WriteLine();
            result = new ThreeSum().threeSum(new int[] { 1, 2, 3, 4, 5, 6 }, 10);
            foreach (List<int> r in result)
                foreach (int res in r)
                    Console.Write(res + ",");
        }

        private static void twoSum()
        {
            int[] result = new TwoSum().twoSum(new int[] { 1, 2, 3, 4, 5, 6 }, 11);
            foreach (int r in result)
                Console.Write(r + ",");
            Console.WriteLine();
            result = new TwoSum().twoSum(new int[] { 1, 2, 3, 4, 5, 6 }, 15);
            foreach (int r in result)
                Console.Write(r + ",");
            Console.WriteLine();
            result = new TwoSum().twoSum(new int[] { 1, 2, 3, 4, 5, 6 }, 8);
            foreach (int r in result)
                Console.Write(r + ",");
            Console.WriteLine();
            result = new TwoSum().twoSum(new int[] { 1, 2, 3, 4, 5, 6 }, 10);
            foreach (int r in result)
                Console.WriteLine(r + ",");
        }

        private static void Tries()
        {
            string[] keys = { "a", "there", "the","their","by","bye","answer", "hi", "hello", "ans", "why","where","what" };

            Trie trie = new Trie();
            for(int i =0; i< keys.Length; i++)
            {
                trie.insertNode(keys[i]);
            }

            Console.WriteLine("answer is present in the trie: {0}", trie.searchNode("Answer"));
            Console.WriteLine("byefornow is present in the trie: {0}", trie.searchNode("Byefornow"));

            trie.insertNode("quick");
            trie.deleteNode("quick");
            Console.WriteLine("quick is present in the trie: {0}", trie.searchNode("quick"));

            //find the totalnumber of words in the trie
            Console.WriteLine("total number of words in the trie : {0}", totalWords(trie.root));

            Console.WriteLine("list of words in the trie : {0}", findWordsInTrie(trie.root).Count);


        }

        private static List<string> findWordsInTrie(TrieNode root)
        {
            List<string> result = new List<string>();
            string word = "";
            getWords(root, result, 0, ref word);
            return result;
        }

        private static void getWords(TrieNode root, List<string> result, int level, ref string word)
        {
            if (root.isEndWord)
            {
                //current word is stored till the 'level' in the word string
                string temp = "";
                for (int x = 0; x < level; x++)
                {
                    temp += word[x];
                }
                result.Add(temp);
            }
            for (int i = 0; i < 26; i++)
            {
                if (root.children[i] != null)
                {
                    if (level < word.Length)
                    {
                        StringBuilder sb = new StringBuilder(word);
                        sb[level] = (char)(i + 'a');
                        word = sb.ToString();
                    }
                    else
                    {
                        word += (char)(i + 'a');
                    }
                    getWords(root.children[i], result, level + 1, ref word);
                }
            }
        }

        private static int totalWords(TrieNode root)
        {
            int result = 0;

            if (root.isEndWord)
                result++;

            for(int i =0; i < 26; i++)
            {
                if (root.children[i] != null)
                    result += totalWords(root.children[i]);
            }
            return result;
        }
        private static void NIQs()
        {
            NetflixIQ.MaxStack stack = new NetflixIQ.MaxStack();
            stack.push(5);
            stack.push(0);
            stack.push(2);
            stack.push(4);
            stack.push(6);
            stack.push(3);
            stack.push(10);

            Console.WriteLine("Inserted max ratings!");
            Console.WriteLine(stack.getMaxRating());

            stack.pop();
            Console.WriteLine("New rating after pressing back button: {0}", stack.getMaxRating());

            int[] pushOp = { 1, 2, 3, 4, 5 };
            int[] popOp = { 5, 4, 3, 2, 1 };

            NetflixIQ.NIQ niq = new NetflixIQ.NIQ();
            if (niq.isValidOperations(pushOp, popOp))
                Console.WriteLine("Valid Sessions");
            else
                Console.WriteLine("InValid Sessions");


            int[] pushOp2 = { 6, 7, 8, 9, 10 };
            int[] popOp2 = { 8, 10, 7, 9 };

            if (niq.isValidOperations(pushOp2, popOp2))
                Console.WriteLine("Session Successfull!");
            else
                Console.WriteLine("Session Faulty!");

        }

        private static void FIQs()
        {
            FacebookInterviewQuestions.FIQ fiq = new FacebookInterviewQuestions.FIQ();
           // List<List<string>> result = fiq.groupSimilarMessages(new List<string>()  { "lmn", "mno", "pqr", "bcdg", "yza", "tvxz", "xzbd" } );
           // foreach(List<string> message in result)
           // {
           //     Console.WriteLine("[{0}]",string.Join(",",message));
           // }

           // bool[][] friends = new bool[][] { new bool[]{ true, true, false, false,false },
           //                                   new bool[]{ true, true, true, false ,false},
           //                                   new bool[]{ false, true, true, false,false },
           //                                   new bool[]{ false, false, false, true,false },
           //                                   new bool[]{ false, false, false, false,true },
           //                                 };
           // Console.WriteLine("Number of Friends Circles : {0}",
           // new FacebookInterviewQuestions.FIQ().friendCircles(friends, 5));

           // int[] s1 = { 7, 8, 9, 10, 1, 2, 3, 4, 5, 6 };
           // int[] s2 = { 6, 7, 8, 9, 10, 1, 2, 3, 4, 5 };

           //Console.WriteLine("Key is foind in  : {0}",
           //new FacebookInterviewQuestions.FIQ().FindStory(s1,3));

           //Console.WriteLine("Key is foind in  : {0}",
           //new FacebookInterviewQuestions.FIQ().FindStory(s2, 8));

           // RequestLimiter rl = new RequestLimiter();

           // rl.RequestApprover(1, "R1");
           // rl.RequestApprover(2, "R2");
           // rl.RequestApprover(3, "R2");
           // rl.RequestApprover(8, "R1");
           // rl.RequestApprover(10, "R2");


           // Console.WriteLine("flagged words : {0}", new FIQ().flagWords("mooooronnn", "moron"));
           // Console.WriteLine("flagged words : {0}", new FIQ().flagWords("stupid", "stupid"));

            //Console.WriteLine("flagged words : {0}", new FIQ().expressiveWords("dddiiiinnssssssoooo", new string[] { "dinnssoo", "ddinso", "ddiinnso", "ddiinnssoo", "ddiinso", "dinsoo", "ddiinsso", "dinssoo", "dinso" }));
            //Console.WriteLine("flagged words : {0}", new FIQ().expressiveWords("heeellooo", new string[] { "hello", "hi", "helo" }));
            //Console.WriteLine("flagged words : {0}", new FIQ().expressiveWords("tttttllll", new string[] { "tl", "tll", "ttll", "ttl" }));
            //Console.WriteLine("flagged words : {0}", new FIQ().expressiveWords("hurry", new string[] { "hury"}));

            // int[] s3 = { 4,5,6,7,0,1,2 };

            //Console.WriteLine("Key is foind in  : {0}",
            //new FacebookInterviewQuestions.FIQ().SearchRotated(s3, 2));

            string[][] islands = new string[][] { 
                new string[]{ "1","1","0","0" },
                new string[]{ "1","1","0","0" },
                new string[]{ "0","0","1","0" },
                new string[]{ "0","0","0","1" }
            };

            string[][] islands1 = new string[][] {
                new string[]{ "1","1","0","0" },
               
            };
            Console.WriteLine("number of islands  : {0}",
            new FacebookInterviewQuestions.FIQ().numOfIslands(islands));
            Console.WriteLine("number of islands1  : {0}",
           new FacebookInterviewQuestions.FIQ().numOfIslands(islands1));
            Console.WriteLine("number of islands1  : {0}",
           new FacebookInterviewQuestions.FIQ().numOfIslands(null));
        }

        private static void Day31()
        {
            TreeNode root = ConstructBinaryTree();

            Console.WriteLine(new TreesAlgoExpert().SerializeTree(root));
            string input = "15,7,2,#,#,12,10,#,#,13,#,#,20,17,#,#,22,#,#,";
            root = new TreesAlgoExpert().deserializeToTree(input);
            traverseSubTree(root);
            //Console.WriteLine(new TreesAlgoExpert().findClosestNode(root, 3).data);
            //Console.WriteLine(new TreesAlgoExpert().findClosestNode(root, 11).data);
            //Console.WriteLine(new TreesAlgoExpert().findClosestNode(root, 13).data);
            //Console.WriteLine(new TreesAlgoExpert().findClosestNode(root, 22).data);

            //Console.WriteLine(new TreesAlgoExpert().findClosestNodeRecursive(root, 3));
            //Console.WriteLine(new TreesAlgoExpert().findClosestNodeRecursive(root, 11));
            //Console.WriteLine(new TreesAlgoExpert().findClosestNodeRecursive(root, 13));
            //Console.WriteLine(new TreesAlgoExpert().findClosestNodeRecursive(root, 14));
            //Console.WriteLine(new TreesAlgoExpert().findClosestNodeRecursive(root, 22));


            //Console.Write("Inorder traversal : ");
            //new TreesAlgoExpert().inorderTraversal(root);

            //Console.Write("preOrder traversal : ");
            //new TreesAlgoExpert().preOrderTraversal(root);

            //Console.Write("PostOrder traversal : ");
            //new TreesAlgoExpert().postOrderTraversal(root);

            Console.WriteLine(new TreesAlgoExpert().findKthLargestElement(root, 3));
            //Console.WriteLine(new TreesAlgoExpert().findKthLargestElement(root, 9));
            //Console.WriteLine(new TreesAlgoExpert().findKthLargestElement(root, 19));
        }

        private static void Day8()
        {
            Tree tree = new Tree();
            //tree.Add(6);
            //tree.Add(4);
            //TreeNode root = tree.Add(7);

            //traverseSubTree(root);

            //Console.WriteLine("The tree is Symmetric: " + tree.isSymmetric(root).ToString());


            //Console.WriteLine("The tree is Symmetric: " + tree.isSymmetric(tree.AddConstantData()).ToString());

            //tree.BFS(tree.AddDataForTraversal()).ForEach(item => Console.Write(item));
            //Console.WriteLine();

            //tree.DFS(tree.AddDataForTraversal()).ForEach(item => Console.Write(item));

            //Console.WriteLine("\n" + tree.isValidBST(tree.AddDataForTraversal(), null, null));
            //Console.WriteLine("\n" + tree.isValidBST(tree.AddConstantData(), null, null));

            //Console.WriteLine(" the depth of a tree is :" + tree.calcDepthRecursively(tree.AddDataForTraversal()));
            //Console.WriteLine(" the depth of a tree is :" + tree.depthOfTree(tree.AddDataForTraversal()));

            TreeNode root1 = ConstructBinaryTree();
            Console.WriteLine(tree.LCABST(root1, 7, 13).data);
            Console.WriteLine(tree.LCABST(root1, 2, 10).data);
            Console.WriteLine(tree.LCABST(root1, 20, 17).data);
            Console.WriteLine(tree.LCABST(root1, 10, 17).data);

            TreesAdvanced trees = new TreesAdvanced();
            //trees.printLevelOrderTraversal(root1);
            trees.printBoundaryTraversal(root1);
        }

        /// <summary>
        /// Construct BST
        /// </summary>
        /// <returns></returns>
        private static TreeNode ConstructBinaryTree()
        {
            TreeNode root = new TreeNode(15);
            root.left = new TreeNode(7);
            root.right = new TreeNode(20);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(12);
            root.left.right.left = new TreeNode(10);
            root.left.right.right = new TreeNode(13);

            root.right.right = new TreeNode(22);
            root.right.left = new TreeNode(17);
            return root;
        }

        private static void Day7()
        {
            Console.WriteLine(new Maths().getFibonacci(10, new List<int>() { 0,1}));
            Console.WriteLine(new Maths().getFibonacci(1000, new List<int>() { 0, 1 }));
            Console.WriteLine(new Maths().getFibonacci(10000, new List<int>() { 0, 1 }));

            Console.WriteLine(new Maths().GCD(10, 15));
            Console.WriteLine(new Maths().GCD(36, 60));
            Console.WriteLine(new Maths().GCD(32, 23));

            Console.WriteLine(new Maths().LCM(10, 15));
            Console.WriteLine(new Maths().LCM(36, 60));
            Console.WriteLine(new Maths().LCM(32, 23));


        }

        private static void traverseSubTree(TreeNode node)
        {
            if (node == null) return;
              Console.Write(node.data+" -->");
            traverseSubTree(node.left);
            traverseSubTree(node.right);
            
        }
        #region Day6
        static void Day6Problems()
        {
            Permutations ps = new Permutations();
            //List<List<int>> result = ps.getPermutations(new int[] { 1, 2, 3, });
            //foreach(List<int> elements in result)
            //{
            //    elements.ForEach(e => Console.Write(e));
            //    Console.WriteLine("");
            //}

            //Permutations for string
            
            List<List<string>> result1 = ps.permutationsForString("abc");
            foreach (List<string> elements in result1)
            {
                elements.ForEach(e => Console.Write(e));
                Console.WriteLine("");
            }
        }
        #endregion

        #region Day5
        static void Day5()
        {
            StringCompressionPractice sc = new StringCompressionPractice();
            Console.WriteLine(sc.CompressString("AAABBCCCCDEEEEEFFGGGGGGHII"));
            Console.WriteLine(sc.stringCompressionRLE("AAABBCCCCDEEEEEFFGGGGGGHII"));
            Console.WriteLine(sc.unCompressRLE("4A2BC3D8HGI"));
            Console.WriteLine(sc.removeDuplicates("AAABBCCCCDEEEEEAAABBVVVFFGGGGGGHI"));
            Console.WriteLine(sc.removeDuplicates("AAABBCCCCDEEEEEAAABBVVVFFGGGGGGHI"));
        }
        #endregion
        static void Day1()
        {
            //Console.Write(new Day1().alphaPhoneToNumeric("1-1800-CALL-ABC"));
            //Console.Write(new Day1().alphaPhoneToNumeric("1800CALLATT"));

            //Console.WriteLine(new Day1().convertRomanToNumeral("MLXIV"));
            //Console.WriteLine(new Day1().convertRomanToNumeral("MDCLIV"));
            //Console.WriteLine(new Day1().convertRomanToNumeral("IX"));

            Console.WriteLine(new Conversions().convertToRoman(1064));
            Console.WriteLine(new Conversions().convertToRoman(39));
        }


        static void reverseString()
        {

            Console.WriteLine("Enter the string to reverse: ");
            string inputArgs = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            for(int i=inputArgs.Length-1; i > -1; i--)
            {
                sb.Append(inputArgs[i]);
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }

        static bool isValidParanthesis(string inputArgs)
        {
            int length = inputArgs.Length;
            Stack<char> stack = new Stack<char>();

            Hashtable hashMap = new Hashtable();
            hashMap.Add('}', '{');
            hashMap.Add(')', '(');
            hashMap.Add(']', '[');

            foreach(Char ch in inputArgs.ToCharArray())
            {
                if (hashMap.ContainsValue(ch))
                {
                    stack.Push(ch);
                }

                if(stack.Count > 0 && hashMap.ContainsKey(ch))
                {
                    if (stack.Pop() != Convert.ToChar(hashMap[ch]))
                        return false;
                }
            }
            return stack.Count == 0;
        }               
    }
}
