using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class ranking_system : MonoBehaviour
{
    public string player_name;
    public Dictionary<string, int> ranking; // 모든 플레이어명과 점수가 들어갈 딕셔너리
    private static string domain = "http://pckdrms.esy.es/"; //웹페이지주소


    public InputField a1;
    public InputField a2;
    public Text b;
    public string c;
    public string d;
    public int e;

 
    public void nameinput()//맨 처음 참가자 입장
    {
       c = a1.text.ToString();
       StartCoroutine(InitNewPlayer(c));
    }

    public IEnumerator scoreinput()
    {
        d = a2.text.ToString();
        e = System.Int32.Parse(d);
        yield return StartCoroutine(editScore(e, c));
        yield return StartCoroutine(loadRanking());
    }

    public void printganet()
    {
        //여기서부터
    }


    void Start() //새로운 딕셔너리 생성 및 데이터테이블 초기화
    {
        ranking = new Dictionary<string, int>();
        StartCoroutine(loadRanking());
    }

    public void initializelist()
    {
        WWW webRequest = new WWW(domain + "initRanking.php");//한번만 쓰기
        StartCoroutine(loadRanking());
    }

    
    public IEnumerator InitNewPlayer(string player_name)//플레이어명을 받아 서버에 저장공간을 만든다
    {
        string _name = player_name;
        WWW webRequest = new WWW(domain + "initNewPlayer.php?name=" + _name);//이름긴거
        yield return webRequest;
    }

    //플레이어명과 각 파라미터를 받아 DB에 해당 이름으로 저장된 값들을 바꾼다.
    public IEnumerator editScore(int score, string name)
    {
        string _score = score.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editScore.php?name=" + _name + "&score=" + _score);
        yield return webRequest;
    }
    public IEnumerator editAttack(int atk, string name)
    {
        string _atk = atk.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editAttack.php?name=" + _name + "&atk=" + _atk);
        yield return webRequest;
    }
    public IEnumerator editDefense(int def, string name)
    {
        string _def = def.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editDefense.php?name=" + _name + "&def=" + _def);
        yield return webRequest;
    }
    public IEnumerator editGarnet(int garnet, string name)
    {
        string _garnet = garnet.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editGarnet.php?name=" + _name + "&garnet=" + _garnet);
        yield return webRequest;
    }
    public IEnumerator editNoChange(bool nochange, string name)
    {
        string _nochange = nochange.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editNoChange.php?name=" + _name + "&nochange=" + _nochange);
        yield return webRequest;
    }
    public IEnumerator editShield(bool shield, string name)
    {
        string _shield = shield.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editShield.php?name=" + _name + "&shield=" + _shield);
        yield return webRequest;
    }
    public IEnumerator editDeflect(bool deflect, string name)
    {
        string _deflect = deflect.ToString();
        string _name = name;
        WWW webRequest = new WWW(domain + "editDeflect.php?name=" + _name + "&deflect=" + _deflect);
        yield return webRequest;
    }

    //플레이어명과 저장할 변수공간을 받아, 해당 파라미터의 값을 서버에 저장된 값으로 바꾼다.
    public IEnumerator getScore(int score, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getScore.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        score = System.Int32.Parse(result);
    }
    public IEnumerator getAttack(int atk, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getAttack.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        atk = System.Int32.Parse(result);
    }
    public IEnumerator getDefense(int def, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getDefense.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        def = System.Int32.Parse(result);
    }
    public IEnumerator getGernet(int gernet, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getGernet.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        gernet = System.Int32.Parse(result);
    }
    public IEnumerator getNoChange(bool nochange, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getNoChange.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        nochange = System.Boolean.Parse(result);
    }
    public IEnumerator getShield(bool shield, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getShield.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        shield = System.Boolean.Parse(result);
    }
    public IEnumerator getDeflect(bool deflect, string name)
    {
        string _name = name;
        WWW webRequest = new WWW(domain + "getDeflect.php?name=" + _name);
        yield return webRequest;

        string result = webRequest.text;
        deflect = System.Boolean.Parse(result);
    }

    public IEnumerator loadRanking()//딕셔너리 초기화 후 1등부터 등수대로 딕셔너리에 저장
    {
        WWW webRequest = new WWW(domain + "loadRanking.php");
        Debug.Log("서버에서 랭킹을 읽어오는 중...");
        yield return webRequest;
        Debug.Log("로딩 완료");//미지의 오류,지금은 무시 가능(2번째 실행부터 이게 안 떠)

        string[] stringSeparators = new string[] { "\n" };
        string[] lines = webRequest.text.Split(stringSeparators, System.StringSplitOptions.RemoveEmptyEntries);
 
        ranking.Clear();
        for (int i = 0; i < lines.Length; i++)
        {
            string[] _parts = lines[i].Split(',');
            string _name = _parts[0];
            int _score = int.Parse(_parts[1]);
            ranking.Add(_name, _score);
        }
       
    }

    public void printRanking()//저장된 딕셔너리 출력
    {
        int rank = 0;
        b.text = "";
        foreach (KeyValuePair<string, int> kvp in ranking)
        {
            b.text  += "name: " + kvp.Key + "\n";
            b.text  += "score: " + kvp.Value.ToString() + "\n";
            rank++;
        }
    }

}