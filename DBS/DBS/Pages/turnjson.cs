using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class BranchInfo
{
    public string BranchCode { get; set; }
    public string BranchName { get; set; }
    public string BranchAddress { get; set; }
    public string BranchCity { get; set; }
}

public class JsonConverter
{
    public static void ConvertToJsonFile()
    {
        List<BranchInfo> branchList = GetBranchList_004();

        string json = JsonSerializer.Serialize(branchList, new JsonSerializerOptions { WriteIndented = true });

        File.WriteAllText("branches.json", json);

        Console.WriteLine("JSON 檔案已建立。");
    }

    private static List<BranchInfo> GetBranchList_004()
    {
        return new List<BranchInfo>
        {
                new BranchInfo { BranchCode = "0040037臺灣銀行營業部", BranchName = "0037臺灣銀行營業部", BranchAddress = "台北市中正區重慶南路一段120號", BranchCity = "north01" },
                new BranchInfo { BranchCode = "0040059臺灣銀行公庫部", BranchName = "0059臺灣銀行公庫部", BranchAddress = "台北市中正區貴陽街一段120號", BranchCity = "north01" },
                new BranchInfo { BranchCode = "0040071臺灣銀行館前分行", BranchName = "0071臺灣銀行館前分行", BranchAddress = "台北市中正區館前路49號1、2樓", BranchCity = "north01" },
                new BranchInfo { BranchCode = "0040082臺灣銀行信託部", BranchName = "0082臺灣銀行信託部", BranchAddress = "台北市中正區武昌街一段49號", BranchCity = "north01" },
                new BranchInfo { BranchCode = "0040093臺灣銀行臺南分行", BranchName = "0093臺灣銀行臺南分行", BranchAddress = "台南市中西區府前路一段155號一樓及部分二樓", BranchCity = "south02" },
                new BranchInfo { BranchCode = "0040107臺灣銀行臺中分行", BranchName = "0107臺灣銀行臺中分行", BranchAddress = "台中市西區自由路一段140號一至六樓及地下一樓", BranchCity = "central01" },
                new BranchInfo { BranchCode = "0040118臺灣銀行高雄分行", BranchName = "0118臺灣銀行高雄分行", BranchAddress = "高雄市前金區中正四路264號一至三樓及地下一樓", BranchCity = "south01" },
                new BranchInfo { BranchCode = "0040129臺灣銀行基隆分行", BranchName = "0129臺灣銀行基隆分行", BranchAddress = "基隆市中正區義一路16號一、二樓及部分三樓", BranchCity = "north03" },
                new BranchInfo { BranchCode = "0040130臺灣銀行中興新村分行", BranchName = "0130臺灣銀行中興新村分行", BranchAddress = "南投縣南投市中興新村光華路11號一、二樓", BranchCity = "central04" },
                new BranchInfo { BranchCode = "0040141臺灣銀行嘉義分行", BranchName = "0141臺灣銀行嘉義分行", BranchAddress = "嘉義市西區中山路306號一至四樓及地下一樓", BranchCity = "south03" },
                new BranchInfo { BranchCode = "0040152臺灣銀行新竹分行", BranchName = "0152臺灣銀行新竹分行", BranchAddress = "新竹市林森路29號一至三樓及地下一樓", BranchCity = "north04" },
                new BranchInfo { BranchCode = "0040163臺灣銀行彰化分行", BranchName = "0163臺灣銀行彰化分行", BranchAddress = "彰化縣彰化市成功路130號一至四樓及地下一樓", BranchCity = "central03" },
                new BranchInfo { BranchCode = "0040174臺灣銀行屏東分行", BranchName = "0174臺灣銀行屏東分行", BranchAddress = "屏東縣屏東市中山路43號一、二樓及地下一樓", BranchCity = "south05" },
                new BranchInfo { BranchCode = "0040185臺灣銀行花蓮分行", BranchName = "0185臺灣銀行花蓮分行", BranchAddress = "花蓮縣花蓮市公園路3號一至三樓及部分地下一樓", BranchCity = "east01" },
                new BranchInfo { BranchCode = "0040196臺灣銀行延平分行", BranchName = "0196臺灣銀行延平分行", BranchAddress = "台北市大同區南京西路406號一至三及十樓", BranchCity = "north01" },
                new BranchInfo { BranchCode = "0040200臺灣銀行中山分行", BranchName = "0200臺灣銀行中山分行", BranchAddress = "台北市中山區中山北路一段150號一至三樓", BranchCity = "north01" },
                new BranchInfo { BranchCode = "0040211臺灣銀行高雄加工出口區分行", BranchName = "0211臺灣銀行高雄加工出口區分行", BranchAddress = "高雄市前鎮區中一路1號一、二樓及地下一樓", BranchCity = "south01" },
                new BranchInfo { BranchCode = "0040222臺灣銀行宜蘭分行", BranchName = "0222臺灣銀行宜蘭分行", BranchAddress = "宜蘭縣宜蘭市舊城南路50號", BranchCity = "north07" },

        };
    }
}
