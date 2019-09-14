﻿using System.Text;

namespace senrenbanka.murasame.qqbot.HelpDocs
{
    public class GomokuDocs : IDocsBase
    {
        public GomokuDocs() { }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Gomoku/五子棋指令:");
            sb.AppendLine("    /gj 加入五子棋");
            sb.AppendLine("    /ge 退出五子棋");
            sb.AppendLine("    x坐标y坐标(先后顺序不固定,0a和a0效果等同) 落子");
            sb.AppendLine("    /gf 投降");
            sb.AppendLine("    /gc 查看自己的gomoku credit");
            sb.AppendLine("    /gsf <群号> 强制结束该群的游戏 (仅限管理员)");
            sb.AppendLine("    /gcset <qq号> <分数> 设置该玩家的Gomoku Credit (仅限管理员)");
            sb.AppendLine("    /op <qq号> 设置该用户为管理员 (仅限管理员)");
            sb.AppendLine("    /unop <qq号> 取消该用户的管理员资格 (仅限机器人所有者)");
            return sb.ToString();
        }
    }
}