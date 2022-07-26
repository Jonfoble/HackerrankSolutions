#include <bits/stdc++.h>
#include <string.h>

using namespace std;

string ltrim(const string&);
string rtrim(const string&);


string timeInWords(int h, int m) {
    string kek;
    string time;
    string minute;
    if (m > 30)
    {
        h += 1;
    }
    switch (h)
    {
    case 0:
        time = "twelve";
        break;
    case 1:
        time = "one";
        break;
    case 2:
        time = "two";
        break;
    case 3:
        time = "three";
        break;
    case 4:
        time = "four";
        break;
    case 5:
        time = "five";
        break;
    case 6:
        time = "six";
        break;
    case 7:
        time = "seven";
        break;
    case 8:
        time = "eight";
        break;
    case 9:
        time = "nine";
        break;
    case 10:
        time = "ten";
        break;
    case 11:
        time = "eleven";
        break;
    case 12:
        time = "twelve";
        break;
    case 13:
        time = "one";
        break;
    default:
        break;
    }
    switch (m)
    {
    case 1:
        minute = "one minute past";
        break;
    case 2:
        minute = "two minutes past";
        break;
    case 3:
        minute = "three minutes past";
        break;
    case 4:
        minute = "four minutes past";
        break;
    case 5:
        minute = "five minutes past";
        break;
    case 6:
        minute = "six minutes past";
        break;
    case 7:
        minute = "seven minutes past";
        break;
    case 8:
        minute = "eight minutes past";
        break;
    case 9:
        minute = "nine minutes past";
        break;
    case 10:
        minute = "ten minutes past";
        break;
    case 11:
        minute = "eleven minutes past";
        break;
    case 12:
        minute = "twelve minutes past";
        break;
    case 13:
        minute = "thirteen minutes past";
        break;
    case 14:
        minute = "fourteen minutes past";
        break;
    case 15:
        minute = "quarter past";
        break;
    case 16:
        minute = "sixteen minutes past";
        break;
    case 17:
        minute = "seventeen minutes past";
        break;
    case 18:
        minute = "eighteen minutes past";
        break;
    case 19:
        minute = "nineteen minutes past";
        break;
    case 20:
        minute = "twenty minutes past";
        break;
    case 21:
        minute = "twenty one minutes past";
        break;
    case 22:
        minute = "twenty two minutes past";
        break;
    case 23:
        minute = "twenty three minutes past";
        break;
    case 24:
        minute = "twenty four minutes past";
        break;
    case 25:
        minute = "twenty five minutes past";
        break;
    case 26:
        minute = "twenty six minutes past";
        break;
    case 27:
        minute = "twenty seven minutes past";
        break;
    case 28:
        minute = "twenty eight minutes past";
        break;
    case 29:
        minute = "twenty nine minutes past";
        break;
    case 30:
        minute = "half past";
        break;
    case 31:
        minute = "twenty nine minutes to";
        break;
    case 32:
        minute = "twenty eight minutes to";
        break;
    case 33:
        minute = "twenty seven minutes to";
        break;
    case 34:
        minute = "twenty six minutes to";
        break;
    case 35:
        minute = "twenty five minutes to";
        break;
    case 36:
        minute = "twenty four minutes to";
        break;
    case 37:
        minute = "twenty three minutes to";
        break;
    case 38:
        minute = "twenty two minutes to";
        break;
    case 39:
        minute = "twenty one minutes to";
        break;
    case 40:
        minute = "twenty minutes to";
        break;
    case 41:
        minute = "nineteen minutes to";
        break;
    case 42:
        minute = "eighteen minutes to";
        break;
    case 43:
        minute = "seventeen minutes to";
        break;
    case 44:
        minute = "sixteen minutes to";
        break;
    case 45:
        minute = "quarter to";
        break;
    case 46:
        minute = "fourteen minutes to";
        break;
    case 47:
        minute = "thirteen minutes to";
        break;
    case 48:
        minute = "twelve minutes to";
        break;
    case 49:
        minute = "eleven minutes to";
        break;
    case 50:
        minute = "ten minutes to";
        break;
    case 51:
        minute = "nine minutes to";
        break;
    case 52:
        minute = "eight minutes to";
        break;
    case 53:
        minute = "seven minutes to";
        break;
    case 54:
        minute = "six minutes to";
        break;
    case 55:
        minute = "five minutes to";
        break;
    case 56:
        minute = "four minutes to";
        break;
    case 57:
        minute = "three minutes to";
        break;
    case 58:
        minute = "two minutes to";
        break;
    case 59:
        minute = "one minute to";
        break;



    default:
        break;
    }
    if (m == 0)
    {
        kek = time + " o' clock";
    }
    else
    {
        kek = minute + " " + time;
    }
    return kek;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string h_temp;
    getline(cin, h_temp);

    int h = stoi(ltrim(rtrim(h_temp)));

    string m_temp;
    getline(cin, m_temp);

    int m = stoi(ltrim(rtrim(m_temp)));

    string result = timeInWords(h, m);

    fout << result << "\n";

    fout.close();

    return 0;
}

string ltrim(const string& str) {
    string s(str);

    s.erase(
        s.begin(),
        find_if(s.begin(), s.end(), not1(ptr_fun<int, int>(isspace)))
    );

    return s;
}

string rtrim(const string& str) {
    string s(str);

    s.erase(
        find_if(s.rbegin(), s.rend(), not1(ptr_fun<int, int>(isspace))).base(),
        s.end()
    );

    return s;
}
