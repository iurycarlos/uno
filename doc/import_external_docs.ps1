Set-PSDebug -Trace 1

$external_docs =
@(
    @("https://github.com/unoplatform/uno.wasm.bootstrap", "uno.wasm.bootstrap", "3e7cc247cb2851ef9d8293071ed54433e20bfac2"),
    @("https://github.com/unoplatform/uno.themes", "uno.themes", "ff966383a0440d856ea0784fe83f82ef3a8695b1"),
    @("https://github.com/unoplatform/uno.toolkit.ui", "uno.toolkit.ui", "342975face2f5863007ef9dc634a9181ea5ed504"),
    @("https://github.com/unoplatform/uno.check", "uno.check", "1a2049ae6c232c5e7dafdc2b3f0ca55a7a180d58"),
    @("https://github.com/unoplatform/uno.xamlmerge.task", "uno.xamlmerge.task", "a6d2efa69e24e8280c38300b5c1b7a8f2033f9f9"),
    @("https://github.com/unoplatform/figma-docs", "figma-docs", "7b7e6fa1aad6fb97cfef738553694bd5b66f6208"),
    @("https://github.com/unoplatform/uno.extensions", "uno.extensions", "ad8b707fb99dea47781fe588b9e53c6b288338c4")
)

$ErrorActionPreference = 'Stop'

function Assert-ExitCodeIsZero()
{
    if ($LASTEXITCODE -ne 0)
    {
        throw "Exit code must be zero."
	}
}

mkdir articles\external -ErrorAction Continue
pushd articles\external

# ensure long paths are supported on Windows
git config --global core.longpaths true

# Heads - Release
for($i = 0; $i -lt $external_docs.Length; $i++)
{
    $repoUrl=$external_docs[$i][0]
    $repoPath=$external_docs[$i][1]
    $repoBranch=$external_docs[$i][2]

    echo "Cloning $repoPath ($repoUrl@$repoBranch)"

    git clone $repoUrl $repoPath
    Assert-ExitCodeIsZero

    pushd $repoPath
    git checkout $repoBranch
    Assert-ExitCodeIsZero
    popd
}

popd
