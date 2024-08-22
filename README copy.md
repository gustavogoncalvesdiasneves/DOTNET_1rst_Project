# comandos git uteis

git log (mostra todos o historico de commits)

git commit --amend -m "digitar aqui o texto que vai substiuir o ultimo commit recente"

ou 

git commit --amend (vai abrir o vim ou nano para editar)

git reset --soft <hash do commit> (pega TODOS os arquivos do commit e restaura para trabalhar novamente)

 --  <hash do commit> (aparece em git log)

git reset --mixed <hash do commit> (adiciona arquivos na aba do sync para serem commitado "untracked files")


git reset --hard <hash do commit> (CUIDADO! esse pega somente os arquivos que deu commit, remove todos que tiverem local e deixa somente os arquivos commitados)

git reflog (historico mais detalhado)

git pull (sincroniza do remoto pro local)

git checkout -b teste (cria branch teste baseada na branch atual)

git checkout (volta para a branch padrão)

git branch (lista as branchs)

git branch -d teste (deleta a branch teste)

git fetch origin main (baixa na maquina local as alterações do repo remoto)


========= COMANDOS UTEIS NO DIA DIA =========

git diff main origin/main (mostra as diferenças da branch main local com a remota)

-- main (branch local)

-- origin/main (branch remota)

git clone <https/ssh link> --branch teste --single-branch (clona somente do repositoria a branch "teste" no local)

git stash (arquiva a modificações de arquivos para que possa ser feita uma outra branch ou sincronizar do remoto sem perder essas alterações)

git stash list (lista todas as arquivações)

git stash pop (excluir a arquivação)

git stash apply (para trazer as modificações que havia feito e estava arquivado)


