rnd=$RANDOM
loc=westeurope
grp=az400-T03-simplerelease-$rnd
appPlan=simplerelease-$rnd
web=mvc-simplerelease-$rnd

az group create -n $grp -l $loc
az appservice plan create -n $appPlan -g $grp --sku FREE
az webapp create -n $web -g $grp --plan $appPlan