team supply chain si occupa della distribuzione; 
team ottaviani fanno il forecast della domanda per paesi del mondo, su questo si basa il processo di allocazione di gucci
però sono team analitici poco IT, quindi hanno bisogno di lavorare i maniera + strutturata
trovare un modo di farli lavorare in maniera + strutturata, trovare uno strumento per far partire un pilota e installare questo strumento sulla macchina

studiare la versione enterprise: https://enterprise-docs.anaconda.com/en/docs-site-5.2.4/data-science-workflows/index.html

'Anaconda'
data science platform, python distribution with packages pre installed, it simplifies the work, separate envs 

"Enterprise": Scheduling deployment jobs, Monitoring cluster utilization, 

"In order to interact directly with the powershell": .\conda init powershell  -> close and restart powershell

Start-Process "conda.exe"

pip list ##all pkgs installed with anaconda

conda --help ##all cmds with conda

conda list ##py tags all python related

conda install pkg_name

conda search pkg_name

conda env list ##list all the envs

conda remove -n env_name --all  ##removes the whole env

conda create -n env_name

conda activate env_name  ##change env

conda create -n r_env r-essentials r-base

conda deactivate ##back to base

jupyter notebook

jupyter lab


'Jupyter Notebook'

ipython prj rolled into jupyter prj; enable to modify and reproduce realt-time the results;
the notebook is opened on local host;
run cells different modes; download in different formats
the notebooks are JSON under the hood