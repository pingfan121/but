[!(构建状态)(https://travis-ci.org/neo-project/neo-cli.svg?branch=master))(https://travis-ci.org/neo-project/neo-cli)
# #先决条件
您将需要windows或Linux。如果你有一个Mac，使用虚拟机。支持Ubuntu 14和16。Ubuntu 17不受支持。
安装(。网络核心)(https://www.microsoft.com/net/download/core)。
在Linux上，安装LevelDB和SQLite3 dev包。例如,在Ubuntu上:
' ' ' sh
sudo apt-get安装libleveldb-dev sqlite3-dev libunwind8-dev。
' ' '
在Windows上，使用[Neo版本的LevelDB](https://github.com/newproject/leveldb)。
# #下载预编译的二进制文件
参见(官方文档)(http://docs.neo.org/en-us/node/introduction.html)。下载和解封[最新版本](https://github.com/neo-project/neo-cli/release)。
' ' ' sh
dotnet neo-cli.dll
' ' '
# #从源代码编译
克隆neo-cli存储库。
' ' ' sh
cd neo-cli
dotnet恢复
dotnet发布- c版本
' ' '
为了运行，您需要。net核心的1.1.2版本。下载SDK(二进制)(https://www.microsoft.com/net/download/linux)。
假设您在父文件夹中提取.Net:
' ' ' sh
. .dotnet / bin /释放/ netcoreapp1.0 / neo-cli。dll。
' ' '
# #使用
看到(文档)(http://docs.neo.org/en-us/node/cli.html)。例如，尝试“展示状态”或“创建钱包wallet.db3”。
逐句翻译 相似例句